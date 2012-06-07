using System;
using System.IO;

using CAI.COMMANDoptimize.KPI.Models;

namespace CAI.COMMANDoptimize.KPI.Repositories
{
    public class FileKPIRepository : IKPIRepository
    {
        public FileKPIRepository(string provider, string connectionstring)
        {
            _provider = provider;
            _filepath = connectionstring;
        }

        #region IKPIRepository Members

        public User GetUser(string username)
        {
			if (!File.Exists(_filepath))
				throw new FileNotFoundException(_filepath);
			
			
			
            throw new NotImplementedException();
        }

        public Workspace[] GetKPIs(string username, string location)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private
        private string _provider;
        private string _filepath;
        #endregion
    }
}