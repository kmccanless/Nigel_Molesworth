using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data.Odbc;
using System.IO;

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
			if (IsAsnProvider)
                connectionString = ParseAsnFile(connectionString);
            _connectionString = connectionString;
        }

        #endregion

        #region IDatabaseFactory
		
        /// <summary>
        /// IsSqlServerProvider
        /// </summary>
		public bool IsSqlServerProvider
        {
			get	
			{
				return 
					_IsSqlServerProvider(_provider) 
					||
					(_IsOdbcProvider(_provider) && _IsSqlServerProvider(_odbcprovider));
			}
        }
        /// <summary>
        /// IsOracleProvider
        /// </summary>
		public bool IsOracleProvider
        {
			get
			{
				return 
					_IsOracleProvider(_provider)
					||
					(_IsOdbcProvider(_provider) && _IsOracleProvider(_odbcprovider));
			}
        }
        /// <summary>
        /// IsOdbcProvider
        /// </summary>
        public bool IsOdbcProvider
        {
            get { return _IsOdbcProvider(_provider); }
        }
		
        /// <summary>
        /// IsAsnProvider
        /// </summary>
        public bool IsAsnProvider
        {
            get { return _IsFileProvider(_provider); }
        }
		
        /// <summary>
        /// Create a database connection
        /// </summary>
        /// <returns>IDbConnection reference to a specific provider connection object</returns>
        public IDbConnection Create()
        {          
            IDbConnection connection = null;
			if (_IsSqlServerProvider(_provider))
				connection = new SqlConnection(_connectionString);
			else if (_IsOracleProvider(_provider))
				connection = new OracleConnection(_connectionString);
			else if (_IsOdbcProvider(_provider))
				connection = new OdbcConnection(_connectionString);
			else
            	throw new Exception("Unknown Database Provider: " + _provider);
				
            return connection;
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
		
        #endregion

        #region Implementation
		private string ParseAsnFile(string filepath)
		{
			if (!File.Exists(filepath))
				throw new FileNotFoundException(filepath);
			
			using (StreamReader sr = new StreamReader(filepath))
			{
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
					if (line.StartsWith("[paths]"))
					{
						line = sr.ReadLine();	// next line is the db connection info
						// format: 
						//	token=providertype:dsn:databasename|username|password
						//		OR
						//	token=providertype:dsn|username|password
						string[] parts = line.Split('=');
						if (parts.Length < 2)
							throw new ArgumentException("Invalid database connection information found in the ASN file: [" + line + "]");
						
						parts = parts[1].Split(':');
						if (parts.Length < 2)
							throw new ArgumentException("Invalid database connection information found in the ASN file: [" + line + "]");
							
						_provider = cOdbcProviderNameAlt;
						
						string provider = parts[0];
						if (provider.Equals("mss", StringComparison.InvariantCultureIgnoreCase))
							_odbcprovider = cSQLProviderNameAlt;
						else if (provider.Equals("ora", StringComparison.InvariantCultureIgnoreCase))
							_odbcprovider = cOracleProviderNameAlt;
						else
							_odbcprovider = "unknown";
							
						
						string[] dbparts = (parts.Length > 2 ? parts[2] : parts[1]).Split('|');
						
						int index = 0;
						string dsn = parts.Length > 2 ? parts[1] : dbparts[index++];
						string databasename = parts.Length > 2 ? dbparts[index++] : string.Empty;
						string username = dbparts[index++];
						string password = dbparts[index];
						
						return string.Format("DSN={0};user id={1};password={2}", dsn, username, password);
					}
                }
			}
			
			return string.Empty;
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
				
        private bool _IsOdbcProvider(string providerName)
        {
            return _IsProvider(cOdbcProviderName, providerName) ||
				_IsProvider(cOdbcProviderNameAlt, providerName);
        }
		
        private bool _IsFileProvider(string providerName)
        {
            return _IsProvider(cFileProviderName, providerName) ||
				_IsProvider(cFileProviderNameAlt, providerName);
        }
				
        private bool _IsProvider(string provider, string providerName)
        {
            return (string.Compare(provider, providerName, true) == 0);
        }
		
        #endregion

        #region Private
		private const string cSQLProviderName = "MSSQL";
        private const string cSQLProviderNameAlt = "System.Data.SqlClient";
        private const string cOracleProviderName = "ORACLE";
        private const string cOracleProviderNameAlt = "System.Data.OracleClient";
        private const string cOdbcProviderName = "ODBC";
        private const string cOdbcProviderNameAlt = "System.Data.Odbc";
        private const string cFileProviderName = "FILE";
        private const string cFileProviderNameAlt = "System.IO.File";
		
        private string _provider;
		private string _odbcprovider;
        private string _connectionString;
        #endregion
	}
}
