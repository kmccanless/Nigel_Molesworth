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
            throw new NotImplementedException();
        }

        public Workspace[] GetKPIs(string username, string location)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private
        private IDatabaseFactory _dbf;
        #endregion
    }
}