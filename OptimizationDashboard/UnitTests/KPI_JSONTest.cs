using System;

using NUnit.Framework;

using CAI.COMMANDoptimize.KPI.Models;

namespace Models
{
    [TestFixture]
    public class KPI_JSONTest
    {
        [Test]
        public void Serialize()
        {
            string expectedjson = @"{""userName"":""User"",""roleName"":""Role"",""activeLocation"":""1"",""locations"":[""1"",""3"",""5""],""workspaces"":[{""id"":1,""KPIs"":[{""title"":""Total Compliance"",""type"":""02"",""target"":207.0,""units"":230.0,""firstWarn"":195.5,""secondWarn"":184.0},{""title"":""Locked Loads"",""type"":""02"",""target"":11.4,""units"":228.0,""firstWarn"":22.8,""secondWarn"":34.2}]},{""id"":2,""KPIs"":[{""title"":""First Load"",""type"":""01"",""target"":370.0,""units"":36.0,""firstWarn"":740.0,""secondWarn"":1110.0},{""title"":""Job Wait"",""type"":""01"",""target"":416.0,""units"":40.0,""firstWarn"":624.0,""secondWarn"":832.0},{""title"":""Yard Time"",""type"":""01"",""target"":600.0,""units"":40.0,""firstWarn"":800.0,""secondWarn"":1000.0}]}]}";
            KPIDATA_JSON kpijson = new KPIDATA_JSON(MockUser, MockWorkspaces);

            string json = JsonConverter.ToJSON<KPIDATA_JSON>(kpijson);
            Console.Out.WriteLine(json);

            Assert.IsNotEmpty(json, "failed to convert to json");
            Assert.AreNotEqual("{}", json, "failed to convert to json");
            Assert.AreEqual(expectedjson, json, "failed to convert to json");
        }

        private User MockUser
        {
            get
            {
                return new User
                {
                    Username = "User",
                    Role = "Role",
                    Locations = new string[] { "1", "3", "5" },
                    ActiveLocation = "1"                   
                };
            }
        }

        private Workspace[] MockWorkspaces
        {
            get
            {
                return new Workspace[] {
                    new Workspace {
                        Code = "A",
                        Description = "Operational KPIs",
                        KPIs = new CAI.COMMANDoptimize.KPI.Models.KPI[] {
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
                        }
                    },

                    new Workspace {
                        Code = "B",
                        Description = "Truck Cycle KPIs",
                        KPIs = new CAI.COMMANDoptimize.KPI.Models.KPI[] {
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
                        }
			        }
                };


            }
        }
    }
}
