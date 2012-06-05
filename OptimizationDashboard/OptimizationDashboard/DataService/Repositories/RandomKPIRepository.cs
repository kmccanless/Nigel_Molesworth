using System;
using System.Collections.Generic;

using CAI.COMMANDoptimize.KPI.Models;

namespace CAI.COMMANDoptimize.KPI.Repositories
{
    public class RandomKPIRepository : IKPIRepository
    {
        public RandomKPIRepository(int numlocations, int numkpi)
        {
            _numlocations = numlocations;
            _numkpi = numkpi;
        }
        public RandomKPIRepository()
            : this(-1, -1)
        {            
        }

        #region IKPIRepository Members

        public User GetUser(string username)
        {
            User user = new User {
                Username = username,
                Role = string.Empty, 
                Locations = new string[] {}
            };
            if (_numlocations > 0)
            {                
                Random r = new Random();

                string[] roles = new string[] {"Shipper", "Operator", "Manager"};
                user.Role = roles[r.Next(0, roles.Length)];

                int count = r.Next(1, _numlocations);
                user.Locations = new string[count];
                for (int i=0; i<count; i++)
                    user.Locations[i] = r.Next(1, _numlocations+1).ToString();                
            }
            else
            {
                user.Role = "Shipper";
                user.Locations = new string[] { "1", "3", "4", "6" };
            }

            return user;
        }

        public Workspace[] GetKPIs(string username, string location)
        {            
            Workspace A = new Workspace {
                Code = "A",
                Description = "Operational KPIs"
            };
			if (_numkpi > 0)
			{
				A.KPIs = GenerateKPI(location);
			}
			else
			{
                A.KPIs = new CAI.COMMANDoptimize.KPI.Models.KPI[] {
                    new CAI.COMMANDoptimize.KPI.Models.KPI {
						Code = "005",
						Description = "Total Compliance",
						Category = "02",
						Ordinal = 1,
						Actual = 181,
						Units = 230,
						Target = 207,
						Level1 = 195.5M,
						Level2 = 184
                    },
                    new CAI.COMMANDoptimize.KPI.Models.KPI {
						Code = "006",
						Description = "Locked Loads",
						Category = "02",
						Ordinal = 2,
						Actual = 22,
						Units = 228,
						Target = 11.4M,
						Level1 = 22.8M,
						Level2 = 34.2M
                    }
                };
			}
			
            Workspace B = new Workspace {
                Code = "B",
                Description = "Truck Cycle KPIs"
			};
			
			if (_numkpi > 0)
			{
				B.KPIs = GenerateKPI(location);
			}
			else
			{
                B.KPIs = new CAI.COMMANDoptimize.KPI.Models.KPI[] {
                    new CAI.COMMANDoptimize.KPI.Models.KPI {
						Code = "001",
						Description = "First Load",
						Category = "01",
						Ordinal = 1,
						Actual = 885,
						Units = 36,
						Target = 370,
						Level1 = 740,
						Level2 = 1110
                    },
					
                    new CAI.COMMANDoptimize.KPI.Models.KPI {
						Code = "002",
						Description = "Job Wait",
						Category = "01",
						Ordinal = 2,
						Actual = 835,
						Units = 40,
						Target = 416,
						Level1 = 624,
						Level2 = 832
                    },
					
                    new CAI.COMMANDoptimize.KPI.Models.KPI {
						Code = "003",
						Description = "Yard Time",
						Category = "01",
						Ordinal = 3,
						Actual = 860,
						Units = 40,
						Target = 600,
						Level1 = 800,
						Level2 = 1000
                    }
                };
            }

            return new Workspace[] { A, B };
        }

        #endregion

        #region Private
		private CAI.COMMANDoptimize.KPI.Models.KPI[] GenerateKPI(string location)
		{
            Random r = new Random();
            
            int factor = (!string.IsNullOrEmpty(location) && !location.Equals("all", StringComparison.InvariantCultureIgnoreCase)) ? 1
                    : (_numlocations > 0 ? _numlocations : 5);

			KPIType[] kpitypes = new KPIType[] {
				new KPIType {
					Code = "001",
					Description = "In Service to First Load",
					Category = "01",
					Min = 10,
					Max = factor * 100
				},
				new KPIType {
					Code = "002",
					Description = "Waiting On Jobsite to Unload",
					Category = "01",
					Min = 10,
					Max = factor * 100
				},
				new KPIType {
					Code = "003",
					Description = "Waiting in Yard for a Load",
					Category = "01",
					Min = 10,
					Max = factor * 100
				},
				new KPIType {
					Code = "004",
					Description = "End of Day Yard Time",
					Category = "01",
					Min = 10,
					Max = factor * 100
				},
				new KPIType {
					Code = "005",
					Description = "Total Compliance %",
					Category = "02",
					Min = 0,
					Max = factor * 100
				},
				new KPIType {
					Code = "006",
					Description = "Locked Loads %",
					Category = "02",
					Min = 0,
					Max = factor * 100
				},
				new KPIType {
					Code = "007",
					Description = "Punch In to In Service",
					Category = "01",
					Min = 10,
					Max = factor * 100
				},
				new KPIType {
					Code = "008",
					Description = "Print to To Job",
					Category = "01",
					Min = 10,
					Max = factor * 100
				},
				new KPIType {
					Code = "009",
					Description = "Wash to Clock Out",
					Category = "01",
					Min = 10,
					Max = factor * 100
				},
				new KPIType {
					Code = "010",
					Description = "Status Updates %",
					Category = "02",
					Min = 0,
					Max = factor * 100
				}
			};
			
            int count = r.Next(1, _numkpi);
			CAI.COMMANDoptimize.KPI.Models.KPI[] kpis = new CAI.COMMANDoptimize.KPI.Models.KPI[count];
            for (int i=0; i<count; i++)
			{	
				KPIType kpi = kpitypes[r.Next(1, kpitypes.Length)];
                kpis[i] = new CAI.COMMANDoptimize.KPI.Models.KPI {
					Code = kpi.Code,
					Description = kpi.Description,
					Category = kpi.Category,
					Ordinal = i+1,
					Actual = r.Next(kpi.Min, kpi.Max),
					Units = r.Next(kpi.Min, kpi.Max),
					Target = r.Next(kpi.Min, kpi.Max),
					Level1 = r.Next(kpi.Min, kpi.Max),
					Level2 = r.Next(kpi.Min, kpi.Max)
                };
			}
			return kpis;
		}
		
		internal class KPIType
		{
			internal string Code {get;set;}
			internal string Description {get;set;}
			internal string Category {get;set;}
			internal int Min {get;set;}
			internal int Max {get;set;}
		}
		
        private int _numlocations;
        private int _numkpi;
        #endregion
    }
}