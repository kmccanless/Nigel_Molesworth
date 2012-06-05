using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.OracleClient;

namespace CAI.COMMANDoptimize.KPI.Database
{
	/// <summary>
	/// Description of DatabaseFactory.
	/// </summary>
	public class DatabaseFactory : IDatabaseFactory
	{
        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="connectionString"></param>
        public DatabaseFactory(string provider, string connectionString)
        {
            _provider = provider;
            if (IsOracleProvider)
            {
                SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder(connectionString);
                connectionString = string.Format("Data Source={0};user id={1};password={2}", cs.DataSource, cs.UserID, cs.Password);
            }
            _connectionString = connectionString;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="datasource"></param>
        /// <param name="databasename"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public DatabaseFactory(string provider, string datasource, string databasename, string username, string password)
            : this(provider, null)
        {
            _connectionString = MakeConnectionString(provider, datasource, databasename, username, password);
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public DatabaseFactory()
        {
        }
        #endregion

        #region IDatabaseFactory
		
        /// <summary>
        /// IsSqlServerProvider
        /// </summary>
		public bool IsSqlServerProvider
        {
			get{return _IsSqlServerProvider(_provider);}
        }
        /// <summary>
        /// IsOracleProvider
        /// </summary>
		public bool IsOracleProvider
        {
			get{return _IsOracleProvider(_provider);}
        }
		
        /// <summary>
        /// Create a database connection
        /// </summary>
        /// <returns>IDbConnection reference to a specific provider connection object</returns>
        public IDbConnection Create()
        {            
			return MakeConnection(_connectionString);
        }

        /// <summary>
        /// Create a database connection
        /// </summary>
        /// <param name="databasename"></param>
        /// <returns>IDbConnection reference to a specific provider connection object</returns>
        public IDbConnection Create(string databasename)
        {   
			return MakeConnection(MakeConnectionString(_provider, _connectionString, databasename));
        }
		
        /// <summary>
        /// Add a Parameter to a Command
        /// </summary>
        /// <param name="cmd">SQL command </param>
        /// <param name="name">Name of the @parameter in the SQL command</param>
        /// <param name="type">Data type of the parameter</param>
        /// <param name="direction">Parameter direction</param>
        /// <param name="value">Value to assign to the parameter</param>
        /// <returns>Returns the parameter object</returns>
        public IDbDataParameter AddCommandParameter(IDbCommand cmd, string name, DbType type, ParameterDirection direction, Object value)
        {
            IDbDataParameter param = cmd.CreateParameter();
            param.DbType = type;
            param.ParameterName = (IsOracleProvider) ? name.Replace('@', '&') : name;

            if (IsOracleProvider && type == DbType.Guid)
            {
                Guid g = (Guid)value;
                param.Value = g.ToByteArray();
            }
            else
                param.Value = value;

            param.Direction = direction;
            cmd.Parameters.Add(param);

            return param;
        }
		
        /// <summary>
        /// Make a database connection string
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="datasource"></param>
        /// <param name="databasename"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string MakeConnectionString(string providerName, string datasource, string databasename, string username, string password)
        {
            if (_IsSqlServerProvider(providerName))
            {
                SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();

                cs.DataSource = datasource;
                cs.InitialCatalog = databasename;
                if (!string.IsNullOrEmpty(username))
                {
                    cs.IntegratedSecurity = false;
                    cs.UserID = username;
                    cs.Password = password;
                }
                else
                {
                    cs.IntegratedSecurity = true;
                    cs.UserID = null;
                    cs.Password = null;
                }
                cs.Pooling = false;
                cs.PersistSecurityInfo = false;

                return cs.ConnectionString;
            }			
            else if (_IsOracleProvider(providerName))
            {            
                /*  
                SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();

                cs.DataSource = datasource;
                cs.InitialCatalog = databasename;
                if (!string.IsNullOrEmpty(username))
                {
                    cs.IntegratedSecurity = false;
                    cs.UserID = username;
                    cs.Password = password;
                }
                else
                {
                    cs.IntegratedSecurity = true;
                    cs.UserID = null;
                    cs.Password = null;
                }
                cs.Pooling = false;
                cs.PersistSecurityInfo = false;

                return cs.ConnectionString;
                */                

                return string.Format("Data Source={0};user id={1};password={2}", datasource, username, password);
            }

            return null;
        }
        
        /// <summary>
        /// Break a connection string into its parts
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="connstring"></param>
        /// <param name="datasource"></param>
        /// <param name="databasename"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void BreakConnectionString(string providerName, string connstring, 
                                            out string datasource, out string databasename, 
                                            out string username, out string password)
        {
            if (_IsSqlServerProvider(providerName))
            {
                System.Data.SqlClient.SqlConnectionStringBuilder cs = new System.Data.SqlClient.SqlConnectionStringBuilder(connstring);
                datasource = cs.DataSource;
                databasename = cs.InitialCatalog;
                username = cs.UserID;
                password = cs.Password;							
            }
            else if (_IsOracleProvider(providerName))
            {
                System.Data.SqlClient.SqlConnectionStringBuilder cs = new System.Data.SqlClient.SqlConnectionStringBuilder(connstring);
                datasource = cs.DataSource;
                databasename = cs.InitialCatalog;
                username = cs.UserID;
                password = cs.Password;
            }
            else
            {
                datasource = string.Empty;
                databasename = string.Empty;
                username = string.Empty;
                password = string.Empty;
            }
        }
		
        /// <summary>
        /// Test a Provider Connection
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="datasource"></param>
        /// <param name="databasename"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>True if connection is successful</returns>
        public bool TestConnection(string providerName, string datasource, string databasename, string username, string password)
		{
			IDatabaseFactory dbf = new DatabaseFactory(providerName, datasource, databasename, username, password);
            using (IDbConnection db = dbf.Create())
            {
                db.Open();
                return true;
            }
		}
		
        #endregion

        #region Implementation
		private IDbConnection MakeConnection(string connectionstring)
        {            
            IDbConnection connection = null;
			if (IsSqlServerProvider)
				connection = new SqlConnection(connectionstring);
			else if (IsOracleProvider)
				connection = new OracleConnection(connectionstring);
			else
            	throw new Exception("Unknown Database Provider: " + _provider);
				
            return connection;
        }
		
        private string MakeConnectionString(string providerName, string connectionstring, string databasename)
        {
            if (_IsSqlServerProvider(providerName))
            {
                SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder(connectionstring);
				cs.InitialCatalog = databasename;

                return cs.ConnectionString;
            }
            else if (_IsOracleProvider(providerName))
            {                              
                SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder(connectionstring);
                //cs.InitialCatalog = databasename;
				
                //return cs.ConnectionString;                

                return string.Format("Data Source={0};user id={1};password={2}", cs.DataSource, cs.UserID, cs.Password);
            }

            return null;
        }
		
        private bool _IsSqlServerProvider(string providerName)
        {
            return _IsProvider(cSQLProviderName, providerName) ||
				_IsProvider(cSQLProviderNameAlt, providerName);
        }
		
        private bool _IsOracleProvider(string providerName)
        {
            return _IsProvider(cOracleProviderName, providerName) ||
				_IsProvider(cOracleProviderNameAlt, providerName);
        }
				
        private bool _IsProvider(string provider, string providerName)
        {
            return (string.Compare(provider, providerName, true) == 0);
        }
		
        private string ExtractCSPart(string cspart)
        {
            int spos = cspart.IndexOf("=");
            if (spos > -1)            
                return cspart.Substring(spos + 1, cspart.Length - spos - 1);            
            return string.Empty;
        }
		
        #endregion

        #region Private
		private const string cSQLProviderName = "MSSQL";
        private const string cSQLProviderNameAlt = "System.Data.SqlClient";
        private const string cOracleProviderName = "ORACLE";
        private const string cOracleProviderNameAlt = "System.Data.OracleClient";
		
        string _provider;
        string _connectionString;
        #endregion
	}
}
