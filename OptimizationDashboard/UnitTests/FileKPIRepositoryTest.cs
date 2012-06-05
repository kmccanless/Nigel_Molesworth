using System;
using System.Collections.Generic;

using NUnit.Framework;

using CAI.COMMANDoptimize.KPI.Models;
using CAI.COMMANDoptimize.KPI.Repositories;

namespace Repositories
{
    [TestFixture]
    public class FileKPIRepositoryTest
    {
        private const string cFileProvider = "System.IO.File";
        private const string cKPIFile = "KPI.dat";

        private string _testfolderpath;

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            _testfolderpath = dir.Substring(0, dir.IndexOf("bin\\Debug"));
        }

        [Test]
        public void Create()
        {
            IKPIRepository r = new FileKPIRepository(cFileProvider, System.IO.Path.Combine(_testfolderpath, cKPIFile));
            Assert.IsNotNull(r, "failed to create repository");
        }

        [Test]
        public void GetUser()
        {
            IKPIRepository r = new FileKPIRepository(cFileProvider, System.IO.Path.Combine(_testfolderpath, cKPIFile));
            Assert.IsNotNull(r, "failed to create repository");

            User user = r.GetUser("username");
            Assert.IsNotNull(user, "failed to retrieve user");
            Assert.AreEqual("username", user.Username, "failed to retrieve user");
            Assert.AreEqual("Shipper", user.Role, "failed to retrieve user role");
            Assert.IsNotNull(user.Locations, "failed to retrieve user locations");
            Assert.AreEqual(4, user.Locations.Length, "failed to retrieve user locations");
            Assert.AreEqual("1", user.Locations[0], "failed to retrieve user location");
            Assert.AreEqual("3", user.Locations[1], "failed to retrieve user location");
            Assert.AreEqual("4", user.Locations[2], "failed to retrieve user location");
            Assert.AreEqual("6", user.Locations[3], "failed to retrieve user location");
        }

    }
}
