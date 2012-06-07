using System;
using System.Configuration;
using System.Reflection;

using CAI.COMMANDoptimize.KPI.Database;

namespace CAI.COMMANDoptimize.KPI.Repositories
{
    public interface IRepositoryFactory
    {
        IKPIRepository GetRepository();
    }
    public class RepositoryFactory : IRepositoryFactory
    {
        public RepositoryFactory(IRepositoryConfiguration config)
        {
            _config = config;
        }

        #region IRepositoryFactory Members

        public IKPIRepository GetRepository()
        {
            string reposTypeName = this.GetType().Namespace + "." + _config.RepositoryType;  
            Type repostype = Assembly.GetExecutingAssembly().GetType(reposTypeName, true);

            ConnectionStringSettings connection = this.Connection;

            if (repostype.Equals(typeof(DatabaseKPIRepository)))
            {
                return new DatabaseKPIRepository(new DatabaseFactory(connection.ProviderName, connection.ConnectionString));
            }
            
            if (repostype.Equals(typeof(RandomKPIRepository)))
            {                
                return new RandomKPIRepository(connection.ProviderName, connection.ConnectionString);
            }
            
            if (repostype.Equals(typeof(FileKPIRepository)))            
            {
                return new FileKPIRepository(connection.ProviderName, connection.ConnectionString);
            }

            throw new Exception("Invalid Repository specified: " + repostype);
        }
        #endregion

        #region Private
        private ConnectionStringSettings Connection 
        {
            get
            {
                ConnectionStringSettings connection = _config.Connection;
                if (connection == null)
                    throw new Exception(string.Format("Connection named [{0}] not found", _config.ConnectionName));
                return connection;
            }
        }

        private IRepositoryConfiguration _config;
        #endregion
    }
}