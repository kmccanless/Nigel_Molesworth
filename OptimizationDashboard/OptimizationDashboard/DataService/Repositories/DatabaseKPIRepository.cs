using System;
using System.Collections.Generic;

using CAI.COMMANDoptimize.KPI.Database;
using CAI.COMMANDoptimize.KPI.Models;


namespace CAI.COMMANDoptimize.KPI.Repositories
{
    public class DatabaseKPIRepository : IKPIRepository
    {
        public DatabaseKPIRepository(IDatabaseFactory dbf)
        {
            _dbf = dbf;
        }

        #region IKPIRepository Members
		
        public User GetUser(string username)
        {
            using (System.Data.IDbConnection conn = _dbf.Create())
            {
                conn.Open();
                return RetrieveUser(conn, username);
            }            
        }

        public Workspace[] GetKPIs(string rolename, string location, string[] locations)
        {
            if (string.IsNullOrEmpty(rolename))
                throw new Exception("No role assigned for user");

			Workspace A = new Workspace {
	                Code = "A",
	                Description = "Operational KPIs"
	            };
            Workspace B = new Workspace {
                Code = "B",
                Description = "Truck Cycle KPIs"
			};
			
            using (System.Data.IDbConnection conn = _dbf.Create())
            {
                conn.Open();
								
				KPIRole role = RetrieveRole(conn, rolename);
				string[] filterlocations = location.Equals("all", StringComparison.InvariantCultureIgnoreCase)
					? locations
					: new string[] {location};

	            using (System.Data.IDbCommand cmd = conn.CreateCommand())
	            {
	                cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = this.SelectKPISQL(filterlocations);
                    Console.Out.WriteLine(cmd.CommandText);
	                using (System.Data.IDataReader dr = cmd.ExecuteReader())
	                {
						while (dr.Read())
						{
							foreach (KPIDisplay kpi in role.KPIs)
							{
								RetrieveKPI(dr, kpi);
							}
						}
	                }
	            }
				
				List<Models.KPI> akpis = new List<Models.KPI>();
				List<Models.KPI> bkpis = new List<Models.KPI>();
				foreach (KPIDisplay kpi in role.KPIs)
				{
					if (kpi.StartTime == null || !kpi.StartTime.HasValue || 
						kpi.EndTime == null || !kpi.EndTime.HasValue ||
						(DateTime.Now >= kpi.StartTime.Value && 
						DateTime.Now < kpi.EndTime.Value))
					{
						List<Models.KPI> wkpis = kpi.Display.StartsWith("A") ? akpis : bkpis;
						wkpis.Add(kpi.KPI);
					}
				}
				
				A.KPIs = akpis.ToArray();
				B.KPIs = bkpis.ToArray();
            }            
			
			return new Workspace[] { A, B };
        }

        #endregion

        #region SQL
        private string SelectUserSQL(string username)
        {
            return string.Format(
@"select user_name, kpi_role_name, kpi_plants
from usnm
where user_name = '{0}'", 
                      username);            
        }

        private string SelectRoleSQL(string rolename)
        {
            return string.Format(
@"select kpi_codes, kpi_display_codes, kpi_display_timers
from kpir
where kpi_role_name = '{0}'", 
                        rolename);
        }
		
		private string SelectKPISQL(string[] locations)
		{
            if (_dbf.IsOracleProvider)
				return SelectKPISQL_Oracle(locations);
			
			return SelectKPISQL_SqlServer(locations);
		}

		private string SelectKPISQL_SqlServer(string[] locations)
		{
			System.Text.StringBuilder sql = new System.Text.StringBuilder();
			foreach (string location in locations)
			{
				if (sql.Length > 0)
					sql.AppendLine("union all");
				sql.AppendFormat(
@"select * from (select top 1
	plant_code
	,record_date
	,kpi001.kpi_display_label as [001label]
	,kpi001.kpi_display_cat as [001category]
	,[first_load_mins] as [001actual]
	,[first_load_units] as [001units]
	,[first_load_target] as [001target]
	,[first_load_warn_1] as [001warn1]
	,[first_load_warn_2] as [001warn2]
     
	,kpi002.kpi_display_label as [002label]
	,kpi002.kpi_display_cat as [002category]
	,[job_wait_mins] as [002actual]
	,[job_wait_units] as [002units]
	,[job_wait_target] as [002target]
	,[job_wait_warn_1] as [002warn1]
	,[job_wait_warn_2] as [002warn2]

	,kpi003.kpi_display_label as [003label]
	,kpi003.kpi_display_cat as [003category]
	,[yard_time_mins] as [003actual]
	,[yard_time_units] as [003units]
	,[yard_time_target] as [003target]
	,[yard_time_warn_1] as [003warn1]
	,[yard_time_warn_2] as [003warn2]
	   
	,kpi004.kpi_display_label as [004label]
	,kpi004.kpi_display_cat as [004category]
	,[eod_yard_mins] as [004actual]
	,[eod_yard_units] as [004units]
	,[eod_yard_target] as [004target]
	,[eod_yard_warn_1] as [004warn1]
	,[eod_yard_warn_2] as [004warn2]
       
	,kpi005.kpi_display_label as [005label]
	,kpi005.kpi_display_cat as [005category]
	,cast( (([truck_compliance_points] + [load_time_compliance_points] + [ret_plant_compliance_points]) / 3.0) as decimal(6,0)) as [005actual]
	,[total_avail_compliance_points] as [005units]
	,[compliance_target] as [005target]
	,[compliance_warn_1] as [005warn1]
	,[compliance_warn_2] as [005warn2]
	   
	,kpi006.kpi_display_label as [006label]
	,kpi006.kpi_display_cat as [006category]
	,[loads_locked] as [006actual]
	,[loads_scheduled] as [006units]
	,[loads_locked_target] as [006target]
	,[loads_locked_warn_1] as [006warn1]
	,[loads_locked_warn_2] as [006warn2]
	   
	,kpi007.kpi_display_label as [007label]
	,kpi007.kpi_display_cat as [007category]
	,[startup_mins] as [007actual]
	,[startup_units] as [007units]
	,[startup_target] as [007target]
	,[startup_warn_1] as [007warn1]
	,[startup_warn_2] as [007warn2]
	  
	,kpi008.kpi_display_label as [008label]
	,kpi008.kpi_display_cat as [008category]
	,[load_mins] as [008actual]
	,[load_units] as [008units]
	,[load_target] as [008target]
	,[load_warn_1] as [008warn1]
	,[load_warn_2] as [008warn2]
	  
	,kpi009.kpi_display_label as [009label]
	,kpi009.kpi_display_cat as [009category]
	,[wash_out_mins] as [009actual]
	,[wash_out_units] as [009units]
	,[wash_out_target] as [009target]
	,[wash_out_warn_1] as [009warn1]
	,[wash_out_warn_2] as [009warn2]
	   
	,kpi010.kpi_display_label as [010label]
	,kpi010.kpi_display_cat as [010category]
	,[auto_status_updates] as [010actual]
	,[total_status_updates] as [010units]
	,[auto_status_target] as [010target]
	,[auto_status_warn_1] as [010warn1]
	,[auto_status_warn_2] as [010warn2]
from 
	okpi
	inner join kpis as kpi001 on kpi001.kpi_code = '001'
	inner join kpis as kpi002 on kpi002.kpi_code = '002'
	inner join kpis as kpi003 on kpi003.kpi_code = '003'
	inner join kpis as kpi004 on kpi004.kpi_code = '004'
	inner join kpis as kpi005 on kpi005.kpi_code = '005'
	inner join kpis as kpi006 on kpi006.kpi_code = '006'
	inner join kpis as kpi007 on kpi007.kpi_code = '007'
	inner join kpis as kpi008 on kpi008.kpi_code = '008'
	inner join kpis as kpi009 on kpi009.kpi_code = '009'
	inner join kpis as kpi010 on kpi010.kpi_code = '010'
where 
	plant_code = '{0,3}'
order by 
	plant_code asc, record_date desc) iq{0}",
							location);
					sql.AppendLine();
			}
			sql.AppendLine("order by plant_code asc, record_date desc");
			
			return sql.ToString();
		}


		private string SelectKPISQL_Oracle(string[] locations)
		{
			System.Text.StringBuilder sql = new System.Text.StringBuilder();
			foreach (string location in locations)
			{
				if (sql.Length > 0)
					sql.AppendLine("union all");
				sql.AppendFormat(
@"select 
	plant_code
	,record_date
	,kpi001.kpi_display_label ""001label""
	,kpi001.kpi_display_cat ""001category""
	,first_load_mins ""001actual""
	,first_load_units ""001units""
	,first_load_target ""001target""
	,first_load_warn_1 ""001warn1""
	,first_load_warn_2 ""001warn2""
     
	,kpi002.kpi_display_label ""002label""
	,kpi002.kpi_display_cat ""002category""
	,job_wait_mins ""002actual""
	,job_wait_units ""002units""
	,job_wait_target ""002target""
	,job_wait_warn_1 ""002warn1""
	,job_wait_warn_2 ""002warn2""

	,kpi003.kpi_display_label ""003label""
	,kpi003.kpi_display_cat ""003category""
	,yard_time_mins ""003actual""
	,yard_time_units ""003units""
	,yard_time_target ""003target""
	,yard_time_warn_1 ""003warn1""
	,yard_time_warn_2 ""003warn2""
	   
	,kpi004.kpi_display_label ""004label""
	,kpi004.kpi_display_cat ""004category""
	,eod_yard_mins ""004actual""
	,eod_yard_units ""004units""
	,eod_yard_target ""004target""
	,eod_yard_warn_1 ""004warn1""
	,eod_yard_warn_2 ""004warn2""
       
	,kpi005.kpi_display_label ""005label""
	,kpi005.kpi_display_cat ""005category""
	,cast( ((truck_compliance_points + load_time_compliance_points + ret_plant_compliance_points) / 3.0) as number(6,0)) as ""005actual""
	,total_avail_compliance_points ""005units""
	,compliance_target ""005target""
	,compliance_warn_1 ""005warn1""
	,compliance_warn_2 ""005warn2""
	   
	,kpi006.kpi_display_label ""006label""
	,kpi006.kpi_display_cat ""006category""
	,loads_locked ""006actual""
	,loads_scheduled ""006units""
	,loads_locked_target ""006target""
	,loads_locked_warn_1 ""006warn1""
	,loads_locked_warn_2 ""006warn2""
	   
	,kpi007.kpi_display_label ""007label""
	,kpi007.kpi_display_cat ""007category""
	,startup_mins ""007actual""
	,startup_units ""007units""
	,startup_target ""007target""
	,startup_warn_1 ""007warn1""
	,startup_warn_2 ""007warn2""
	  
	,kpi008.kpi_display_label ""008label""
	,kpi008.kpi_display_cat ""008category""
	,load_mins ""008actual""
	,load_units ""008units""
	,load_target ""008target""
	,load_warn_1 ""008warn1""
	,load_warn_2 ""008warn2""
	  
	,kpi009.kpi_display_label ""009label""
	,kpi009.kpi_display_cat ""009category""
	,wash_out_mins ""009actual""
	,wash_out_units ""009units""
	,wash_out_target ""009target""
	,wash_out_warn_1 ""009warn1""
	,wash_out_warn_2 ""009warn2""
	   
	,kpi010.kpi_display_label ""010label""
	,kpi010.kpi_display_cat ""010category""
	,auto_status_updates ""010actual""
	,total_status_updates ""010units""
	,auto_status_target ""010target""
	,auto_status_warn_1 ""010warn1""
	,auto_status_warn_2 ""010warn2""
	,RANK() OVER (ORDER BY plant_code asc, record_date desc) kpirank
from
	okpi
	inner join kpis kpi001 on kpi001.kpi_code = '001'
	inner join kpis kpi002 on kpi002.kpi_code = '002'
	inner join kpis kpi003 on kpi003.kpi_code = '003'
	inner join kpis kpi004 on kpi004.kpi_code = '004'
	inner join kpis kpi005 on kpi005.kpi_code = '005'
	inner join kpis kpi006 on kpi006.kpi_code = '006'
	inner join kpis kpi007 on kpi007.kpi_code = '007'
	inner join kpis kpi008 on kpi008.kpi_code = '008'
	inner join kpis kpi009 on kpi009.kpi_code = '009'
	inner join kpis kpi010 on kpi010.kpi_code = '010'
where 
	plant_code = '{0,3}'",
						location);
			}

            return @"select * from (" + sql.ToString() + ") iq where iq.kpirank <= 1 order by iq.plant_code asc, iq.record_date desc";
		}
		
        #endregion

        #region Private
		internal class KPIRole
		{
			internal string Name {get;set;}
			internal KPIDisplay[] KPIs {get;set;}
		}
		internal class KPIDisplay
		{
			internal string Code {get;set;}
			internal string Display {get;set;}
			internal DateTime? StartTime {get;set;}
			internal DateTime? EndTime {get;set;}
			internal Models.KPI KPI {get;set;}
		}
		
        private User RetrieveUser(System.Data.IDbConnection conn, string username)
        {
            using (System.Data.IDbCommand cmd = conn.CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = this.SelectUserSQL(username);
                using (System.Data.IDataReader dr = cmd.ExecuteReader())
                {
                    if (!dr.Read()) return null;

                    string uname = RetrieveFieldString(dr, "user_name");
                    string kpirole = RetrieveFieldString(dr, "kpi_role_name");
                    string locations_packed = RetrieveFieldString(dr, "kpi_plants");

                    User user = new User
                    {
                        Username = uname.Trim(),
                        Role = kpirole.Trim(),
                        Locations = new string[] { }
                    };

                    if (!string.IsNullOrEmpty(locations_packed))
                    {
                        // gotta whack the empy last entry (padded with 20 spaces)
                        // there must be a more elegant way to do this!
                        string[] locations = locations_packed.Split(cDelimitter);                        
                        user.Locations = new string[locations.Length - 1];
                        for (int i = 0; i<locations.Length -1; i++)
                            user.Locations[i] = locations[i].Trim();
                    }
                    return user;
                }
            }
        }

		private KPIRole RetrieveRole(System.Data.IDbConnection conn, string rolename)
		{
            using (System.Data.IDbCommand cmd = conn.CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = this.SelectRoleSQL(rolename);
                using (System.Data.IDataReader dr = cmd.ExecuteReader())
                {
                    if (!dr.Read()) return null;

                    string kpis_packed = RetrieveFieldString(dr, "kpi_codes");
                    string displays_packed = RetrieveFieldString(dr, "kpi_display_codes");
                    string timers_packed = RetrieveFieldString(dr, "kpi_display_timers");

					KPIRole role = new KPIRole
                    {
                        Name = rolename,
                        KPIs = new KPIDisplay[] { }
                    };

                    if (!string.IsNullOrEmpty(kpis_packed))
                    {						
                        string[] kpis = kpis_packed.Split(cDelimitter);
                        string[] displays = displays_packed.Split(cDelimitter);
                        string[] timers = timers_packed.Split(cDelimitter);
						
                        role.KPIs = new KPIDisplay[kpis.Length];
						
                        for (int i = 0; i<kpis.Length && i<displays.Length && i<timers.Length; i++)
						{
							DateTime? starttime = null;
							DateTime? endtime = null;
							if (!string.IsNullOrEmpty(timers[i]))
							{
								string[] tparts = timers[i].Split('-');
                                if (tparts.Length > 0)
                                    starttime = DateTime.Parse(DateTime.Today.ToShortDateString() + " " + tparts[0]);
                                if (tparts.Length > 1)
                                    endtime = DateTime.Parse(DateTime.Today.ToShortDateString() + " " + tparts[1]);
							}

                            role.KPIs[i] = new KPIDisplay
                            {
                                Code = kpis[i].Trim(),
                                Display = displays[i].Trim(),
                                StartTime = starttime,
                                EndTime = endtime,
                                KPI = new Models.KPI {
                                    Code = kpis[i].Trim(),
                                    Description = string.Empty,
									Category = string.Empty,
									Actual = 0M,
									Units = 0M,
									Target = 0M,
									Level1 = 0M,
									Level2 = 0M
                                }
                            };
						}
                    }
                    return role;
                }
            }
		}

		private void RetrieveKPI(System.Data.IDataReader dr, KPIDisplay kpi)
		{
			string s = RetrieveFieldString(dr, kpi.Code + "label");
			if (!string.IsNullOrEmpty(s))
				kpi.KPI.Description = s.Trim();
			s = RetrieveFieldString(dr, kpi.Code + "category");
			if (!string.IsNullOrEmpty(s))
				kpi.KPI.Category = s.Trim();
			kpi.KPI.Actual += RetrieveFieldDecimal(dr, kpi.Code + "actual");
			kpi.KPI.Units += RetrieveFieldDecimal(dr, kpi.Code + "units"); 
			kpi.KPI.Target += RetrieveFieldDecimal(dr, kpi.Code + "target"); 
			kpi.KPI.Level1 += RetrieveFieldDecimal(dr, kpi.Code + "warn1"); 
			kpi.KPI.Level2 += RetrieveFieldDecimal(dr, kpi.Code + "warn2"); 
			
		}
		
        private string RetrieveFieldString(System.Data.IDataReader dr, string fieldname)
        {
            if (dr[fieldname] != null && dr[fieldname] != System.DBNull.Value)
                return dr[fieldname].ToString();
            return null;
        }

        private decimal RetrieveFieldDecimal(System.Data.IDataReader dr, string fieldname)
        {
            if (dr[fieldname] != null && dr[fieldname] != System.DBNull.Value)
                return (decimal)dr[fieldname];
		
			return 0M;
        }

        private const char cDelimitter = '|';
		
        private IDatabaseFactory _dbf;
        #endregion
    }
}