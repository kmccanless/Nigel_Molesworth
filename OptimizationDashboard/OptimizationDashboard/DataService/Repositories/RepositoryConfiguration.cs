using System;
using System.Configuration;
using System.Web.Configuration;

namespace CAI.COMMANDoptimize.KPI.Repositories
{
    public interface IRepositoryConfiguration
    {
        string RepositoryType { get; }
        string ConnectionName { get; }
        ConnectionStringSettings Connection { get; }
    }

    public class RepositoryConfiguration : IRepositoryConfiguration
    {
        #region IRepositoryConfiguration Members

        public string RepositoryType
        {
            get { return WebConfigurationManager.AppSettings["repository"]; }
        }

        public string ConnectionName
        {
            get { return WebConfigurationManager.AppSettings["connection"]; }
        }

        public ConnectionStringSettings Connection
        {
            get 
            {
                return WebConfigurationManager.ConnectionStrings[this.ConnectionName];
            }
        }

        #endregion
    }
}