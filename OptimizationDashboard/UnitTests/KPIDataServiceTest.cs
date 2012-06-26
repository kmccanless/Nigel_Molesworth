using System;
using System.Collections.Generic;

using NUnit.Framework;

using CAI.COMMANDoptimize.KPI.Dataservice;
using CAI.COMMANDoptimize.KPI.Repositories;

namespace DataService
{
    [TestFixture]
    public class KPIDataServiceTest
    {
        private const string cUser = "username";
        private const string cAllLocations = "All";
        private const string cPollTime = "300000";
        private IRepositoryFactory _factory;

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            _factory = new RepositoryFactory(new Mocks.MockRepositoryConfigurationMockRandom());
        }

        [Test]
        public void Create()
        {
            IKPIDataService ds = new KPIDataService(_factory);
            Assert.IsNotNull(ds, "failed to create data service");
        }

        [Test]
        public void GetKPI()
        {
            string expectedjson = @"{""userName"":""username"",""roleName"":""Shipper"",""activeLocation"":""All"",""pollTime"":""300000"",""locations"":[""1"",""3"",""4"",""6""],""workspaces"":[{""id"":1,""KPIs"":[{""title"":""Total Compliance"",""type"":""02"",""value"":181.0,""target"":207.0,""units"":230.0,""firstWarn"":195.5,""secondWarn"":184.0},{""title"":""Locked Loads"",""type"":""02"",""value"":22.0,""target"":11.4,""units"":228.0,""firstWarn"":22.8,""secondWarn"":34.2}]},{""id"":2,""KPIs"":[{""title"":""First Load"",""type"":""01"",""value"":885.0,""target"":370.0,""units"":36.0,""firstWarn"":740.0,""secondWarn"":1110.0},{""title"":""Job Wait"",""type"":""01"",""value"":835.0,""target"":416.0,""units"":40.0,""firstWarn"":624.0,""secondWarn"":832.0},{""title"":""Yard Time"",""type"":""01"",""value"":860.0,""target"":600.0,""units"":40.0,""firstWarn"":800.0,""secondWarn"":1000.0}]}]}";

            IKPIDataService ds = new KPIDataService(_factory);
            Assert.IsNotNull(ds, "failed to create data service");

            string json = ds.GetKPI(cUser, cAllLocations, cPollTime);

            Console.Out.WriteLine(json);

            Assert.IsNotEmpty(json, "failed to convert to json");
            Assert.AreNotEqual("{}", json, "failed to convert to json");
            Assert.AreEqual(expectedjson, json, "failed to convert to json");
        }

    }
}
