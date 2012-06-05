using System;
using System.Collections.Generic;

using NUnit.Framework;

using CAI.COMMANDoptimize.KPI.Repositories;

namespace Repositories
{    
    [TestFixture]
    public class RepositoryFactoryTest
    {
        private const string cDBConnectionString = "";
        private const string cDBFilePath = "";

        [Test]
        public void Create()
        {
            IRepositoryFactory f = new RepositoryFactory(new Mocks.MockRepositoryConfigurationMockRandom());
            Assert.IsNotNull(f, "failed to create repo factory");            
        }

        [Test]
        public void GetRepository_Random()
        {
            IRepositoryFactory f = new RepositoryFactory(new Mocks.MockRepositoryConfigurationMockRandom());
            Assert.IsNotNull(f, "failed to create repo factory");

            IKPIRepository repo = f.GetRepository();
            Assert.IsNotNull(repo, "failed to get repository from factory");
            Assert.IsInstanceOf<RandomKPIRepository>(repo, "failed to get repository from factory");
        }

        [Test]
        public void GetRepository_File()
        {
            IRepositoryFactory f = new RepositoryFactory(new Mocks.MockRepositoryConfigurationMockFile(cDBFilePath));
            Assert.IsNotNull(f, "failed to create repo factory");

            IKPIRepository repo = f.GetRepository();
            Assert.IsNotNull(repo, "failed to get repository from factory");
            Assert.IsInstanceOf<FileKPIRepository>(repo, "failed to get repository from factory");
        }

        [Test]
        public void GetRepository_Database()
        {
            IRepositoryFactory f = new RepositoryFactory(new Mocks.MockRepositoryConfigurationDatabase(cDBConnectionString));
            Assert.IsNotNull(f, "failed to create repo factory");

            IKPIRepository repo = f.GetRepository();
            Assert.IsNotNull(repo, "failed to get repository from factory");
            Assert.IsInstanceOf<DatabaseKPIRepository>(repo, "failed to get repository from factory");
        }

    }
}
