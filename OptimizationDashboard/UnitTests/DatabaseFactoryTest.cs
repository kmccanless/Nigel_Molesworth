using System;
using System.Data;

using NUnit.Framework;

using CAI.COMMANDoptimize.KPI.Database;

namespace Data
{
    [TestFixture]
    public class DatabaseFactoryTest
    {

        [Test]
        public void Create_SqlServer()
        {
			IDatabaseFactory f = new DatabaseFactory("System.Data.SqlClient",
													"Data Source=localhost;User ID=cmdseries;Password=cmdseries;Initial Catalog=cmdseries;Persist Security Info=False;Pooling=False");
			Assert.IsNotNull(f, "failed to create factory");
			Assert.IsTrue(f.IsSqlServerProvider, "failed to create factory");
            using (IDbConnection db = f.Create())
            {
                Assert.IsNotNull(db, "failed to create sql connection");
                Assert.IsInstanceOf<System.Data.SqlClient.SqlConnection>(db, "failed to create sql connection");
                using (IDbCommand cmd = db.CreateCommand())
                {
                    IDbDataParameter p = f.AddCommandParameter(cmd, "Foo", DbType.String, ParameterDirection.Input, 1);
                    Assert.IsNotNull(p, "failed to create sql command parameter");
                }
            }
        }
		
        [Test]
        public void Create_Oracle()
        {
			IDatabaseFactory f = new DatabaseFactory("System.Data.OracleClient",
													"Data Source=orcl11g;user id=cmdseries;password=cmdseries");
			Assert.IsNotNull(f, "failed to create factory");
			Assert.IsTrue(f.IsOracleProvider, "failed to create factory");
            using (IDbConnection db = f.Create())
            {
                Assert.IsNotNull(db, "failed to create oracle connection");
                Assert.IsInstanceOf<System.Data.OracleClient.OracleConnection>(db, "failed to create oracle connection");
                using (IDbCommand cmd = db.CreateCommand())
                {
                    IDbDataParameter p = f.AddCommandParameter(cmd, "Foo", DbType.String, ParameterDirection.Input, 1);
                    Assert.IsNotNull(p, "failed to create oracle command parameter");
                }
            }
        }
		
        [Test]
        public void Create_Odbc()
        {
			IDatabaseFactory f = new DatabaseFactory("System.Data.Odbc",
													"DSN=CS08;user id=cmdseries;password=cmdseries");
			Assert.IsNotNull(f, "failed to create factory");
			Assert.IsFalse(f.IsSqlServerProvider, "failed to create factory");
			Assert.IsFalse(f.IsOracleProvider, "failed to create factory");
            using (IDbConnection db = f.Create())
            {
                Assert.IsNotNull(db, "failed to create odbc connection");
                Assert.IsInstanceOf<System.Data.Odbc.OdbcConnection>(db, "failed to create odbc connection");
                using (IDbCommand cmd = db.CreateCommand())
                {
                    IDbDataParameter p = f.AddCommandParameter(cmd, "Foo", DbType.String, ParameterDirection.Input, 1);
                    Assert.IsNotNull(p, "failed to create odbc command parameter");
                }
            }
        }
		
        [Test]
        public void Create_OdbcFromAsn_SqlServer()
        {
			IDatabaseFactory f = new DatabaseFactory("System.IO.File",
                                                    System.IO.Path.Combine(this.TestFolderPath, "cmdserie.mssql.asn"));
			Assert.IsNotNull(f, "failed to create factory");
			Assert.IsTrue(f.IsSqlServerProvider, "failed to create factory");
			Assert.IsFalse(f.IsOracleProvider, "failed to create factory");
            using (IDbConnection db = f.Create())
            {
                Assert.IsNotNull(db, "failed to create odbc connection");
                Assert.IsInstanceOf<System.Data.Odbc.OdbcConnection>(db, "failed to create odbc connection");
                using (IDbCommand cmd = db.CreateCommand())
                {
                    IDbDataParameter p = f.AddCommandParameter(cmd, "Foo", DbType.String, ParameterDirection.Input, 1);
                    Assert.IsNotNull(p, "failed to create odbc command parameter");
                }
            }
        }
		
        [Test]
        public void Create_OdbcFromAsn_Oracle()
        {
		
			IDatabaseFactory f = new DatabaseFactory("System.IO.File",
                                                    System.IO.Path.Combine(this.TestFolderPath, "cmdserie.ora.asn"));
			Assert.IsNotNull(f, "failed to create factory");
			Assert.IsFalse(f.IsSqlServerProvider, "failed to create factory");
			Assert.IsTrue(f.IsOracleProvider, "failed to create factory");
            using (IDbConnection db = f.Create())
            {
                Assert.IsNotNull(db, "failed to create odbc connection");
                Assert.IsInstanceOf<System.Data.Odbc.OdbcConnection>(db, "failed to create odbc connection");
                using (IDbCommand cmd = db.CreateCommand())
                {
                    IDbDataParameter p = f.AddCommandParameter(cmd, "Foo", DbType.String, ParameterDirection.Input, 1);
                    Assert.IsNotNull(p, "failed to create odbc command parameter");
                }
            }
        }

        private string TestFolderPath
        {
            get
            {
    			string dir = //AppDomain.CurrentDomain.BaseDirectory;
                    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase.Substring("file:///".Length));

                return dir.Substring(0, dir.IndexOf("bin\\Debug"));
            }
        }
    }
}
