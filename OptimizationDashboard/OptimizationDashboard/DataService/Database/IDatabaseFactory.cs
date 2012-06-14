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
        /// Database name
        /// </summary>
        string DatabaseName { get; }

        /// <summary>
        /// Create a database connection
        /// </summary>
        /// <returns>IDbConnection reference to a specific provider connection object</returns>
        IDbConnection Create();

        /// <summary>
        /// Create a database connection
        /// </summary>
        /// <param name="databasename">s</param>
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
        /// Translate the parameter symbol
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        string TranslateCommandParamSymbol(string sql);
	}
}
