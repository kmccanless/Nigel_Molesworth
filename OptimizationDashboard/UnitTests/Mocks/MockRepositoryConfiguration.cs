using System;
using System.Configuration;

using CAI.COMMANDoptimize.KPI.Repositories;

namespace Mocks
{
    internal class MockRepositoryConfigurationMockRandom : IRepositoryConfiguration
    {
        internal MockRepositoryConfigurationMockRandom()
        {
        }
        #region IRepositoryConfiguration Members

        public string RepositoryType
        {
            get { return "RandomKPIRepository"; }
        }

        public string ConnectionName
        {
            get { return "RandomData"; }
        }

        public ConnectionStringSettings Connection
        {
            get { return new ConnectionStringSettings(this.ConnectionName, "-1", "-1"); }
        }

        #endregion
    }

    internal class MockRepositoryConfigurationMockFile : IRepositoryConfiguration
    {
        internal MockRepositoryConfigurationMockFile(string sourcefile)
        {
            _sourcefile = sourcefile;
        }
        #region IRepositoryConfiguration Members

        public string RepositoryType
        {
            get { return "FileKPIRepository"; }
        }

        public string ConnectionName
        {
            get { return "MockSourceConnection"; }
        }

        public ConnectionStringSettings Connection
        {
            get { return new ConnectionStringSettings(this.ConnectionName, _sourcefile, "System.IO.File"); }
        }

        #endregion

        private string _sourcefile;        
    }

    internal class MockRepositoryConfigurationDatabase : IRepositoryConfiguration
    {
        internal MockRepositoryConfigurationDatabase(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        #region IRepositoryConfiguration Members

        public string RepositoryType
        {
            get { return "DatabaseKPIRepository"; }
        }

        public string ConnectionName
        {
            get { return "MockCSConnection"; }
        }

        public ConnectionStringSettings Connection
        {
            get { return new ConnectionStringSettings(this.ConnectionName, _connectionstring, "System.Data.SqlClient"); }
        }

        #endregion

        private string _connectionstring;
    }

}
