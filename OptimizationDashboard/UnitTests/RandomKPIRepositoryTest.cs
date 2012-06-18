using System;
using System.Collections.Generic;

using NUnit.Framework;

using CAI.COMMANDoptimize.KPI.Models;
using CAI.COMMANDoptimize.KPI.Repositories;

namespace Repositories
{
    [TestFixture]
    public class RandomKPIRepositoryTest
    {
        private const string cUser = "username";
        private const string cRole = "Shipper";
        private const string cAllLocations = "All";

        [Test]
        public void Create()
        {
            IKPIRepository r = new RandomKPIRepository();
            Assert.IsNotNull(r, "failed to create repository");
        }

        [Test]
        public void GetUser()
        {
            IKPIRepository r = new RandomKPIRepository();
            Assert.IsNotNull(r, "failed to create repository");

            User user = r.GetUser(cUser);
            Assert.IsNotNull(user, "failed to retrieve user");
            Assert.AreEqual(cUser, user.Username, "failed to retrieve user");
            Assert.AreEqual(cRole, user.Role, "failed to retrieve user role");
            Assert.IsNotNull(user.Locations, "failed to retrieve user locations");
            Assert.AreEqual(4, user.Locations.Length, "failed to retrieve user locations");
            Assert.AreEqual("1", user.Locations[0], "failed to retrieve user location");
            Assert.AreEqual("3", user.Locations[1], "failed to retrieve user location");
            Assert.AreEqual("4", user.Locations[2], "failed to retrieve user location");
            Assert.AreEqual("6", user.Locations[3], "failed to retrieve user location");
        }

        [Test]
        public void GetUser_Random()
        {
            IKPIRepository r = new RandomKPIRepository(10, 0);
            Assert.IsNotNull(r, "failed to create repository");

            User user = r.GetUser(cUser);
            Assert.IsNotNull(user, "failed to retrieve user");
            Assert.AreEqual(cUser, user.Username, "failed to retrieve user");
            Assert.IsNotEmpty(user.Role, "failed to retrieve user role");            
            Assert.IsNotNull(user.Locations, "failed to retrieve user locations");
            Assert.Greater(user.Locations.Length, 0, "failed to retrieve user locations");
            Assert.LessOrEqual(user.Locations.Length, 10, "failed to retrieve user locations");
        }

        [Test]
        public void GetKPIs()
        {
            IKPIRepository r = new RandomKPIRepository();
            Assert.IsNotNull(r, "failed to create repository");

            Workspace[] kpis = r.GetKPIs(cUser, cAllLocations, new string[]{});
            Assert.IsNotNull(kpis, "failed to retrieve KPIs");
            Assert.AreEqual(2, kpis.Length, "failed to retrieve KPIs");

            Assert.AreEqual("A", kpis[0].Code, "failed to retrieve KPI");
            Assert.AreEqual("Operational KPIs", kpis[0].Description, "failed to retrieve KPI");
            Assert.IsNotNull(kpis[0].KPIs, "failed to retrieve KPI");
            Assert.AreEqual(2, kpis[0].KPIs.Length, "failed to retrieve KPI");
			
            Assert.AreEqual("005", kpis[0].KPIs[0].Code, "failed to retrieve KPI");
            Assert.AreEqual("Total Compliance", kpis[0].KPIs[0].Description, "failed to retrieve KPI");
            Assert.AreEqual("02", kpis[0].KPIs[0].Category, "failed to retrieve KPI");            
            Assert.AreEqual(181, kpis[0].KPIs[0].Actual, "failed to retrieve KPI");
            Assert.AreEqual(230, kpis[0].KPIs[0].Units, "failed to retrieve KPI");
            Assert.AreEqual(207, kpis[0].KPIs[0].Target, "failed to retrieve KPI");
            Assert.AreEqual(195.5M, kpis[0].KPIs[0].Level1, "failed to retrieve KPI");
            Assert.AreEqual(184, kpis[0].KPIs[0].Level2, "failed to retrieve KPI");
			
            Assert.AreEqual("006", kpis[0].KPIs[1].Code, "failed to retrieve KPI");
            Assert.AreEqual("Locked Loads", kpis[0].KPIs[1].Description, "failed to retrieve KPI");
            Assert.AreEqual("02", kpis[0].KPIs[1].Category, "failed to retrieve KPI");            
            Assert.AreEqual(22, kpis[0].KPIs[1].Actual, "failed to retrieve KPI");
            Assert.AreEqual(228, kpis[0].KPIs[1].Units, "failed to retrieve KPI");
            Assert.AreEqual(11.4M, kpis[0].KPIs[1].Target, "failed to retrieve KPI");
            Assert.AreEqual(22.8M, kpis[0].KPIs[1].Level1, "failed to retrieve KPI");
            Assert.AreEqual(34.2M, kpis[0].KPIs[1].Level2, "failed to retrieve KPI");


            Assert.AreEqual("B", kpis[1].Code, "failed to retrieve KPI");
            Assert.AreEqual("Truck Cycle KPIs", kpis[1].Description, "failed to retrieve KPI");
            Assert.IsNotNull(kpis[1].KPIs, "failed to retrieve KPI");
            Assert.AreEqual(3, kpis[1].KPIs.Length, "failed to retrieve KPI");
            Assert.AreEqual("001", kpis[1].KPIs[0].Code, "failed to retrieve KPI");
            Assert.AreEqual("First Load", kpis[1].KPIs[0].Description, "failed to retrieve KPI");
            Assert.AreEqual("01", kpis[1].KPIs[0].Category, "failed to retrieve KPI");            
            Assert.AreEqual(885, kpis[1].KPIs[0].Actual, "failed to retrieve KPI");
            Assert.AreEqual(36, kpis[1].KPIs[0].Units, "failed to retrieve KPI");
            Assert.AreEqual(370, kpis[1].KPIs[0].Target, "failed to retrieve KPI");
            Assert.AreEqual(740, kpis[1].KPIs[0].Level1, "failed to retrieve KPI");
            Assert.AreEqual(1110, kpis[1].KPIs[0].Level2, "failed to retrieve KPI");

            Assert.AreEqual("002", kpis[1].KPIs[1].Code, "failed to retrieve KPI");
            Assert.AreEqual("Job Wait", kpis[1].KPIs[1].Description, "failed to retrieve KPI");
            Assert.AreEqual("01", kpis[1].KPIs[1].Category, "failed to retrieve KPI");            
            Assert.AreEqual(835, kpis[1].KPIs[1].Actual, "failed to retrieve KPI");
            Assert.AreEqual(40, kpis[1].KPIs[1].Units, "failed to retrieve KPI");
            Assert.AreEqual(416, kpis[1].KPIs[1].Target, "failed to retrieve KPI");
            Assert.AreEqual(624, kpis[1].KPIs[1].Level1, "failed to retrieve KPI");
            Assert.AreEqual(832, kpis[1].KPIs[1].Level2, "failed to retrieve KPI");

            Assert.AreEqual("003", kpis[1].KPIs[2].Code, "failed to retrieve KPI");
            Assert.AreEqual("Yard Time", kpis[1].KPIs[2].Description, "failed to retrieve KPI");
            Assert.AreEqual("01", kpis[1].KPIs[2].Category, "failed to retrieve KPI");            
            Assert.AreEqual(860, kpis[1].KPIs[2].Actual, "failed to retrieve KPI");
            Assert.AreEqual(40, kpis[1].KPIs[2].Units, "failed to retrieve KPI");
            Assert.AreEqual(600, kpis[1].KPIs[2].Target, "failed to retrieve KPI");
            Assert.AreEqual(800, kpis[1].KPIs[2].Level1, "failed to retrieve KPI");
            Assert.AreEqual(1000, kpis[1].KPIs[2].Level2, "failed to retrieve KPI");
        }
		
       // [Test]
        public void GetKPIs_Random()
        {
            IKPIRepository r = new RandomKPIRepository(5, 10);
            Assert.IsNotNull(r, "failed to create repository");

            Workspace[] kpis = r.GetKPIs(cUser, cAllLocations, new string[]{});
            Assert.IsNotNull(kpis, "failed to retrieve KPIs");
            Assert.AreEqual(2, kpis.Length, "failed to retrieve KPIs");
			
            Assert.AreEqual("A", kpis[0].Code, "failed to retrieve KPI");
            Assert.AreEqual("Operational KPIs", kpis[0].Description, "failed to retrieve KPI");
            Assert.IsNotNull(kpis[0].KPIs, "failed to retrieve KPI");
            //Assert.Greater(kpis[0].KPIs.Length, 0, "failed to retrieve KPI");
            Assert.LessOrEqual(kpis[0].KPIs.Length, 10, "failed to retrieve KPI");
			foreach (CAI.COMMANDoptimize.KPI.Models.KPI kpi in kpis[0].KPIs)
			{
            	Assert.IsNotEmpty(kpi.Code, "failed to retrieve KPI");
            	Assert.IsNotEmpty(kpi.Description, "failed to retrieve KPI");
            	Assert.IsNotEmpty(kpi.Category, "failed to retrieve KPI");
				
            	Assert.Greater(kpi.Actual, 0, "failed to retrieve KPI");
	            Assert.LessOrEqual(kpi.Actual, 10000, "failed to retrieve KPI");
				
            	Assert.Greater(kpi.Units, 0, "failed to retrieve KPI");
	            Assert.LessOrEqual(kpi.Units, 10000, "failed to retrieve KPI");
				
            	Assert.Greater(kpi.Target, 0, "failed to retrieve KPI");
	            Assert.LessOrEqual(kpi.Target, 10000, "failed to retrieve KPI");
				
            	Assert.Greater(kpi.Level1, 0, "failed to retrieve KPI");
	            Assert.LessOrEqual(kpi.Level1, 10000, "failed to retrieve KPI");
				
            	Assert.Greater(kpi.Level2, 0, "failed to retrieve KPI");
	            Assert.LessOrEqual(kpi.Level2, 10000, "failed to retrieve KPI");
			}
			
			
            Assert.AreEqual("B", kpis[1].Code, "failed to retrieve KPI");
            Assert.AreEqual("Truck Cycle KPIs", kpis[1].Description, "failed to retrieve KPI");
            Assert.IsNotNull(kpis[1].KPIs, "failed to retrieve KPI");
            //Assert.Greater(kpis[1].KPIs.Length, 0, "failed to retrieve KPI");
            Assert.LessOrEqual(kpis[1].KPIs.Length, 10, "failed to retrieve KPI");
			foreach (CAI.COMMANDoptimize.KPI.Models.KPI kpi in kpis[1].KPIs)
			{
            	Assert.IsNotEmpty(kpi.Code, "failed to retrieve KPI");
            	Assert.IsNotEmpty(kpi.Description, "failed to retrieve KPI");
            	Assert.IsNotEmpty(kpi.Category, "failed to retrieve KPI");
				
            	Assert.Greater(kpi.Actual, 0, "failed to retrieve KPI");
	            Assert.LessOrEqual(kpi.Actual, 10000, "failed to retrieve KPI");
				
            	Assert.Greater(kpi.Units, 0, "failed to retrieve KPI");
	            Assert.LessOrEqual(kpi.Units, 10000, "failed to retrieve KPI");
				
            	Assert.Greater(kpi.Target, 0, "failed to retrieve KPI");
	            Assert.LessOrEqual(kpi.Target, 10000, "failed to retrieve KPI");
				
            	Assert.Greater(kpi.Level1, 0, "failed to retrieve KPI");
	            Assert.LessOrEqual(kpi.Level1, 10000, "failed to retrieve KPI");
				
            	Assert.Greater(kpi.Level2, 0, "failed to retrieve KPI");
	            Assert.LessOrEqual(kpi.Level2, 10000, "failed to retrieve KPI");
			}
			
			/*
            // ensure that A != B
            for (int i=0; i<kpis[0].KPIs.Length && i<kpis[1].KPIs.Length; i++)            
            {
                CAI.COMMANDoptimize.KPI.Models.KPI kpiA = kpis[0].KPIs[i];
                CAI.COMMANDoptimize.KPI.Models.KPI kpiB = kpis[1].KPIs[i];
                
                Assert.AreNotSame(kpiA, kpiB, "failed to retrieve KPI");
                Assert.AreNotEqual(kpiA.Code, kpiB.Code, "failed to retrieve KPI");
                Assert.AreNotEqual(kpiA.Description, kpiB.Description, "failed to retrieve KPI");
                //Assert.AreNotEqual(kpiA.Category, kpiB.Category, "failed to retrieve KPI");
                Assert.AreNotEqual(kpiA.Actual, kpiB.Actual, "failed to retrieve KPI");
                Assert.AreNotEqual(kpiA.Units, kpiB.Units, "failed to retrieve KPI");
                Assert.AreNotEqual(kpiA.Target, kpiB.Target, "failed to retrieve KPI");
                Assert.AreNotEqual(kpiA.Level1, kpiB.Level1, "failed to retrieve KPI");
                Assert.AreNotEqual(kpiA.Level2, kpiB.Level2, "failed to retrieve KPI");
            }
            */
		}
    }
}