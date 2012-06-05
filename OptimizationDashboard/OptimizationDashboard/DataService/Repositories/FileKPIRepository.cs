using System;
using System.Collections.Generic;

using CAI.COMMANDoptimize.KPI.Models;

namespace CAI.COMMANDoptimize.KPI.Repositories
{
    public class FileKPIRepository : IKPIRepository
    {
        public FileKPIRepository(string provider, string connectionstring)
        {
            _provider = provider;
            _connectionstring = connectionstring;
        }

        #region IKPIRepository Members

        public User GetUser(string username)
        {
            throw new NotImplementedException();
        }

        public Workspace[] GetKPIs(string username, string location)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private
        private string _provider;
        private string _connectionstring;
        #endregion
    }
}