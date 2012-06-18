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
            _r = new Random();
        }
        public RandomKPIRepository(string numlocations, string numkpi)
            : this(Convert.ToInt32(numlocations), Convert.ToInt32(numkpi))
        {
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
                string[] roles = new string[] {"Shipper", "Operator", "Manager"};
                user.Role = roles[_r.Next(0, roles.Length)];

                int count = _r.Next(1, _numlocations);
                IList<string> locations = new List<string>();
                for (int i = 0; i < 50; i++)
                    locations.Add((i + 1).ToString());
                SortedList<int, string> randomlocations = new SortedList<int, string>();
                
                for (int i = 0; i < count; i++)
                {
                    string loc = locations[_r.Next(0, locations.Count)];
                    randomlocations.Add(Convert.ToInt32(loc), loc);                    
                    locations.Remove(loc);
                }

                user.Locations = new string[randomlocations.Count];
                int j = 0;
                foreach (KeyValuePair<int, string> kvp in randomlocations)
                {
                    user.Locations[j++] = kvp.Value;
                }
            }
            else
            {
                user.Role = "Shipper";
                user.Locations = new string[] { "1", "3", "4", "6" };
            }

            return user;
        }

        public Workspace[] GetKPIs(string rolename, string location, string[] locations)
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
			
            int count = _r.Next(0, _numkpi+1);
			CAI.COMMANDoptimize.KPI.Models.KPI[] kpis = new CAI.COMMANDoptimize.KPI.Models.KPI[count];
            for (int i=0; i<count; i++)
			{	
				KPIType kpi = kpitypes[_r.Next(0, kpitypes.Length)];
                kpis[i] = new CAI.COMMANDoptimize.KPI.Models.KPI {
					Code = kpi.Code,
					Description = kpi.Description,
					Category = kpi.Category,					
					Actual = _r.Next(kpi.Min, kpi.Max + 1),
                    Units = _r.Next(kpi.Min, kpi.Max + 1),
                    Target = _r.Next(kpi.Min, kpi.Max + 1),
                    Level1 = _r.Next(kpi.Min, kpi.Max + 1),
                    Level2 = _r.Next(kpi.Min, kpi.Max + 1)
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
        private Random _r;
        #endregion
    }
}