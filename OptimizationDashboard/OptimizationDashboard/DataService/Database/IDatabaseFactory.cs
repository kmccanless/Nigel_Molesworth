using System;
using System.Data;

namespace CAI.COMMANDoptimize.KPI.Database
{
	/// <summary>
	/// Description of IDatabaseFactory.
	/// </summary>
	public interface IDatabaseFactory
	{
        /// <summary>
        /// IsSqlServerProvider
        /// </summary>
		bool IsSqlServerProvider {get;}
        /// <summary>
        /// IsOracleProvider
        /// </summary>
		bool IsOracleProvider {get;}
			
        /// <summary>
        /// Create a database connection
        /// </summary>
        /// <returns>IDbConnection reference to a specific provider connection object</returns>
        IDbConnection Create();

        /// <summary>
        /// Create a database connection
        /// </summary>
        /// <param name="databasename"></param>
        /// <returns>IDbConnection reference to a specific provider connection object</returns>
        IDbConnection Create(string databasename);

        /// <summary>
        /// Add a Parameter to a Command
        /// </summary>
        /// <param name="cmd">SQL command </param>
        /// <param name="name">Name of the @parameter in the SQL command</param>
        /// <param name="type">Data type of the parameter</param>
        /// <param name="direction">Parameter direction</param>
        /// <param name="value">Value to assign to the parameter</param>
        /// <returns>Returns the parameter object</returns>
        IDbDataParameter AddCommandParameter(IDbCommand cmd, string name, DbType type, ParameterDirection direction, Object value);

        /// <summary>
        /// Make a database connection string
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="datasource"></param>
        /// <param name="databasename"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        string MakeConnectionString(string providerName, string datasource, string databasename, string username, string password);
		
        /// <summary>
        /// Break a connection string into its parts
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="connstring"></param>
        /// <param name="datasource"></param>
        /// <param name="databasename"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        void BreakConnectionString(string providerName, string connstring,
                                            out string datasource, out string databasename,
                                            out string username, out string password);
		
        /// <summary>
        /// Test a Provider Connection
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="datasource"></param>
        /// <param name="databasename"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>True if connection is successful</returns>
        bool TestConnection(string providerName, string datasource, string databasename, string username, string password);
	}
}
