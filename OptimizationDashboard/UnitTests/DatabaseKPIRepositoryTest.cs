using System;
using System.Collections.Generic;
using NUnit.Framework;

using CAI.COMMANDoptimize.KPI.Database;
using CAI.COMMANDoptimize.KPI.Models;
using CAI.COMMANDoptimize.KPI.Repositories;

namespace Repositories
{
#warning To include these tests in AppHarbor must have a database add-on
    [TestFixture]
    public class DatabaseKPIRepositoryTest
    {
        private const string cSqlProvider = "System.Data.SqlClient";
        private const string cSqlConnectionString = "Data Source=localhost;User ID=sa;Password=mudbatch;Initial Catalog=OptimizationKPI;Persist Security Info=False;Pooling=False";

        private const string cOraProvider = "System.Data.OracleClient";
        private const string cOraConnectionString = "Data Source=ora11glab;user id=optkpi;password=kpi";

        private const string cOdbcSqlProvider = "System.Data.Odbc";
        private const string cOdbcSqlConnectionString = "DSN=sql2k8lab;Database=OptimizationKPI;uid=sa;pwd=mudbatch";

        private const string cOdbcOraProvider = "System.Data.Odbc";
        private const string cOdbcOraConnectionString = "DSN=ora11glab;user id=optkpi;password=kpi";

        private const string cAppHarborSqlProvider = "System.Data.SqlClient";
        private const string cAppHarborSqlConnectionString = "Server=233d4c10-e551-4711-b80b-a07600e292af.sqlserver.sequelizer.com;Database=db233d4c10e5514711b80ba07600e292af;User ID=zeticekeiwdciore;Password=F8yVd4WJz5XZMSdaNfV8F3EPrLN7ocuXDVgrXrU8wk3iuGEJXiynURLLBRDzoXuw;";


        private IDatabaseFactory _dbf = new DatabaseFactory(
                //cSqlProvider, cSqlConnectionString
                //cOraProvider, cOraConnectionString
                //cOdbcSqlProvider, cOdbcSqlConnectionString, cSqlProvider, "OptimizationKPI"
                //cOdbcOraProvider, cOdbcOraConnectionString, cOraProvider
                cAppHarborSqlProvider, cAppHarborSqlConnectionString 
                );

        [TestFixtureSetUp]
        public void FixtureSetup()
        {            
            CreateDatabase();
            CreateSchema();
            PopulateData();
        }
        
        [TestFixtureTearDown]
        public void FixtureTeardown()
        {
            DropSchema();
            DropDatabase();
        }

        [Test]
        public void Create()
        {
            IKPIRepository r = new DatabaseKPIRepository(_dbf);
            Assert.IsNotNull(r, "failed to create repository");
        }

        [Test]
        public void GetUser_1()
        {
            IKPIRepository r = new DatabaseKPIRepository(_dbf);
            Assert.IsNotNull(r, "failed to create repository");

            User user = r.GetUser("user1");
            Assert.IsNotNull(user, "failed to retrieve user");
            Assert.AreEqual("user1", user.Username, "failed to retrieve user");
            Assert.AreEqual("Role1", user.Role, "failed to retrieve user role");
            Assert.IsNotNull(user.Locations, "failed to retrieve user locations");
            Assert.AreEqual(7, user.Locations.Length, "failed to retrieve user locations");
            Assert.AreEqual("1", user.Locations[0], "failed to retrieve user location");
            Assert.AreEqual("2", user.Locations[1], "failed to retrieve user location");
            Assert.AreEqual("3", user.Locations[2], "failed to retrieve user location");
            Assert.AreEqual("5", user.Locations[3], "failed to retrieve user location");
            Assert.AreEqual("6", user.Locations[4], "failed to retrieve user location");
            Assert.AreEqual("7", user.Locations[5], "failed to retrieve user location");
            Assert.AreEqual("8", user.Locations[6], "failed to retrieve user location");
        }

        [Test]
        public void GetUser_2()
        {
            IKPIRepository r = new DatabaseKPIRepository(_dbf);
            Assert.IsNotNull(r, "failed to create repository");

            User user = r.GetUser("user2");
            Assert.IsNotNull(user, "failed to retrieve user");
            Assert.AreEqual("user2", user.Username, "failed to retrieve user");
            Assert.AreEqual("Role2", user.Role, "failed to retrieve user role");
            Assert.IsNotNull(user.Locations, "failed to retrieve user locations");
            Assert.AreEqual(4, user.Locations.Length, "failed to retrieve user locations");
            Assert.AreEqual("3", user.Locations[0], "failed to retrieve user location");            
            Assert.AreEqual("5", user.Locations[1], "failed to retrieve user location");
            Assert.AreEqual("6", user.Locations[2], "failed to retrieve user location");            
            Assert.AreEqual("7", user.Locations[3], "failed to retrieve user location");            
        }
		
        //[Test]
        //public void GetKPIs_User2_LocationAll()
        //{
        //    IKPIRepository r = new DatabaseKPIRepository(_dbf);
        //    Assert.IsNotNull(r, "failed to create repository");
			
        //    Workspace[] workspaces = r.GetKPIs("Role2", "all", new string[]{"3","5","6","7"});
        //    Assert.IsNotNull(workspaces, "failed to retrieve KPIs");
        //    Assert.AreEqual(2, workspaces.Length, "failed to retrieve KPIs");
			
        //    Assert.AreEqual("A", workspaces[0].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("Operational KPIs", workspaces[0].Description, "failed to retrieve KPI");
        //    Assert.IsNotNull(workspaces[0].KPIs, "failed to retrieve KPI");
        //    Assert.AreEqual(2, workspaces[0].KPIs.Length, "failed to retrieve KPI");
			
        //    int i=0;
        //    Assert.AreEqual("005", workspaces[0].KPIs[i].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("TOTAL COMPLIANCE", workspaces[0].KPIs[i].Description, "failed to retrieve KPI");
        //    Assert.AreEqual("02", workspaces[0].KPIs[i].Category, "failed to retrieve KPI");
        //    Assert.AreEqual(181M, workspaces[0].KPIs[i].Actual, "failed to retrieve KPI");
        //    Assert.AreEqual(230M, workspaces[0].KPIs[i].Units, "failed to retrieve KPI");
        //    Assert.AreEqual(208M, workspaces[0].KPIs[i].Target, "failed to retrieve KPI");
        //    Assert.AreEqual(195M, workspaces[0].KPIs[i].Level1, "failed to retrieve KPI");
        //    Assert.AreEqual(184M, workspaces[0].KPIs[i].Level2, "failed to retrieve KPI");
        //    i++;
			
        //    Assert.AreEqual("006", workspaces[0].KPIs[i].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("LOCKED LOADS", workspaces[0].KPIs[i].Description, "failed to retrieve KPI");
        //    Assert.AreEqual("02", workspaces[0].KPIs[i].Category, "failed to retrieve KPI");
        //    Assert.AreEqual(22M, workspaces[0].KPIs[i].Actual, "failed to retrieve KPI");
        //    Assert.AreEqual(228M, workspaces[0].KPIs[i].Units, "failed to retrieve KPI");
        //    Assert.AreEqual(12M, workspaces[0].KPIs[i].Target, "failed to retrieve KPI");
        //    Assert.AreEqual(24M, workspaces[0].KPIs[i].Level1, "failed to retrieve KPI");
        //    Assert.AreEqual(34M, workspaces[0].KPIs[i].Level2, "failed to retrieve KPI");
			
        //    Assert.AreEqual("B", workspaces[1].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("Truck Cycle KPIs", workspaces[1].Description, "failed to retrieve KPI");
        //    Assert.IsNotNull(workspaces[1].KPIs, "failed to retrieve KPI");
        //    Assert.AreEqual(3, workspaces[1].KPIs.Length, "failed to retrieve KPI");
			
        //    i = 0;
        //    Assert.AreEqual("001", workspaces[1].KPIs[i].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("FIRST LOAD", workspaces[1].KPIs[i].Description, "failed to retrieve KPI");
        //    Assert.AreEqual("01", workspaces[1].KPIs[i].Category, "failed to retrieve KPI");
        //    Assert.AreEqual(885M, workspaces[1].KPIs[i].Actual, "failed to retrieve KPI");
        //    Assert.AreEqual(36M, workspaces[1].KPIs[i].Units, "failed to retrieve KPI");
        //    Assert.AreEqual(370M, workspaces[1].KPIs[i].Target, "failed to retrieve KPI");
        //    Assert.AreEqual(740M, workspaces[1].KPIs[i].Level1, "failed to retrieve KPI");
        //    Assert.AreEqual(1110M, workspaces[1].KPIs[i].Level2, "failed to retrieve KPI");
			
        //    i++;
        //    Assert.AreEqual("002", workspaces[1].KPIs[i].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("JOB WAIT", workspaces[1].KPIs[i].Description, "failed to retrieve KPI");
        //    Assert.AreEqual("01", workspaces[1].KPIs[i].Category, "failed to retrieve KPI");
        //    Assert.AreEqual(835M, workspaces[1].KPIs[i].Actual, "failed to retrieve KPI");
        //    Assert.AreEqual(40M, workspaces[1].KPIs[i].Units, "failed to retrieve KPI");
        //    Assert.AreEqual(416M, workspaces[1].KPIs[i].Target, "failed to retrieve KPI");
        //    Assert.AreEqual(624M, workspaces[1].KPIs[i].Level1, "failed to retrieve KPI");
        //    Assert.AreEqual(832M, workspaces[1].KPIs[i].Level2, "failed to retrieve KPI");
			
        //    i++;
        //    Assert.AreEqual("003", workspaces[1].KPIs[i].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("YARD TIME", workspaces[1].KPIs[i].Description, "failed to retrieve KPI");
        //    Assert.AreEqual("01", workspaces[1].KPIs[i].Category, "failed to retrieve KPI");
        //    Assert.AreEqual(860M, workspaces[1].KPIs[i].Actual, "failed to retrieve KPI");
        //    Assert.AreEqual(40M, workspaces[1].KPIs[i].Units, "failed to retrieve KPI");
        //    Assert.AreEqual(600M, workspaces[1].KPIs[i].Target, "failed to retrieve KPI");
        //    Assert.AreEqual(800M, workspaces[1].KPIs[i].Level1, "failed to retrieve KPI");
        //    Assert.AreEqual(1000M, workspaces[1].KPIs[i].Level2, "failed to retrieve KPI");
        //}
				
        [Test]
        //public void GetKPIs_User2_Location6()
        //{
        //    IKPIRepository r = new DatabaseKPIRepository(_dbf);
        //    Assert.IsNotNull(r, "failed to create repository");
			
        //    Workspace[] workspaces = r.GetKPIs("Role2", "all", new string[]{"6"});
        //    Assert.IsNotNull(workspaces, "failed to retrieve KPIs");
        //    Assert.AreEqual(2, workspaces.Length, "failed to retrieve KPIs");
			
        //    Assert.AreEqual("A", workspaces[0].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("Operational KPIs", workspaces[0].Description, "failed to retrieve KPI");
        //    Assert.IsNotNull(workspaces[0].KPIs, "failed to retrieve KPI");
        //    Assert.AreEqual(2, workspaces[0].KPIs.Length, "failed to retrieve KPI");
			
        //    int i=0;
        //    Assert.AreEqual("005", workspaces[0].KPIs[i].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("TOTAL COMPLIANCE", workspaces[0].KPIs[i].Description, "failed to retrieve KPI");
        //    Assert.AreEqual("02", workspaces[0].KPIs[i].Category, "failed to retrieve KPI");
        //    Assert.AreEqual(41M, workspaces[0].KPIs[i].Actual, "failed to retrieve KPI");
        //    Assert.AreEqual(55M, workspaces[0].KPIs[i].Units, "failed to retrieve KPI");
        //    Assert.AreEqual(50M, workspaces[0].KPIs[i].Target, "failed to retrieve KPI");
        //    Assert.AreEqual(47M, workspaces[0].KPIs[i].Level1, "failed to retrieve KPI");
        //    Assert.AreEqual(44M, workspaces[0].KPIs[i].Level2, "failed to retrieve KPI");
        //    i++;
			
        //    Assert.AreEqual("006", workspaces[0].KPIs[i].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("LOCKED LOADS", workspaces[0].KPIs[i].Description, "failed to retrieve KPI");
        //    Assert.AreEqual("02", workspaces[0].KPIs[i].Category, "failed to retrieve KPI");
        //    Assert.AreEqual(9M, workspaces[0].KPIs[i].Actual, "failed to retrieve KPI");
        //    Assert.AreEqual(55M, workspaces[0].KPIs[i].Units, "failed to retrieve KPI");
        //    Assert.AreEqual(3M, workspaces[0].KPIs[i].Target, "failed to retrieve KPI");
        //    Assert.AreEqual(6M, workspaces[0].KPIs[i].Level1, "failed to retrieve KPI");
        //    Assert.AreEqual(8M, workspaces[0].KPIs[i].Level2, "failed to retrieve KPI");
			
        //    Assert.AreEqual("B", workspaces[1].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("Truck Cycle KPIs", workspaces[1].Description, "failed to retrieve KPI");
        //    Assert.IsNotNull(workspaces[1].KPIs, "failed to retrieve KPI");
        //    Assert.AreEqual(3, workspaces[1].KPIs.Length, "failed to retrieve KPI");
			
        //    i = 0;
        //    Assert.AreEqual("001", workspaces[1].KPIs[i].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("FIRST LOAD", workspaces[1].KPIs[i].Description, "failed to retrieve KPI");
        //    Assert.AreEqual("01", workspaces[1].KPIs[i].Category, "failed to retrieve KPI");
        //    Assert.AreEqual(300M, workspaces[1].KPIs[i].Actual, "failed to retrieve KPI");
        //    Assert.AreEqual(6M, workspaces[1].KPIs[i].Units, "failed to retrieve KPI");
        //    Assert.AreEqual(60M, workspaces[1].KPIs[i].Target, "failed to retrieve KPI");
        //    Assert.AreEqual(120M, workspaces[1].KPIs[i].Level1, "failed to retrieve KPI");
        //    Assert.AreEqual(180M, workspaces[1].KPIs[i].Level2, "failed to retrieve KPI");
			
        //    i++;
        //    Assert.AreEqual("002", workspaces[1].KPIs[i].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("JOB WAIT", workspaces[1].KPIs[i].Description, "failed to retrieve KPI");
        //    Assert.AreEqual("01", workspaces[1].KPIs[i].Category, "failed to retrieve KPI");
        //    Assert.AreEqual(300M, workspaces[1].KPIs[i].Actual, "failed to retrieve KPI");
        //    Assert.AreEqual(8M, workspaces[1].KPIs[i].Units, "failed to retrieve KPI");
        //    Assert.AreEqual(80M, workspaces[1].KPIs[i].Target, "failed to retrieve KPI");
        //    Assert.AreEqual(120M, workspaces[1].KPIs[i].Level1, "failed to retrieve KPI");
        //    Assert.AreEqual(160M, workspaces[1].KPIs[i].Level2, "failed to retrieve KPI");
			
        //    i++;
        //    Assert.AreEqual("003", workspaces[1].KPIs[i].Code, "failed to retrieve KPI");
        //    Assert.AreEqual("YARD TIME", workspaces[1].KPIs[i].Description, "failed to retrieve KPI");
        //    Assert.AreEqual("01", workspaces[1].KPIs[i].Category, "failed to retrieve KPI");
        //    Assert.AreEqual(120M, workspaces[1].KPIs[i].Actual, "failed to retrieve KPI");
        //    Assert.AreEqual(8M, workspaces[1].KPIs[i].Units, "failed to retrieve KPI");
        //    Assert.AreEqual(120M, workspaces[1].KPIs[i].Target, "failed to retrieve KPI");
        //    Assert.AreEqual(160M, workspaces[1].KPIs[i].Level1, "failed to retrieve KPI");
        //    Assert.AreEqual(200M, workspaces[1].KPIs[i].Level2, "failed to retrieve KPI");
        //}
		
        #region Test Data

        private bool DatabaseExists()
        {
            if (!string.IsNullOrEmpty(_dbf.DatabaseName))
            {
                if (_dbf.IsOracleProvider)
                    return OracleDatabaseExists();

                return SqlServerDatabaseExists();
            }
            return false;
        }

        private bool SqlServerDatabaseExists()
        {
            using (System.Data.IDbConnection conn = _dbf.Create("master"))
            {
                conn.Open();

                using (System.Data.IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select 1 from sys.databases where [name] = N'" + _dbf.DatabaseName + "'";

                    object o = cmd.ExecuteScalar();
                    int i = 0;
                    try { i = Convert.ToInt32(o); }
                    catch { }
                    return i > 0;
                }
            }
        }

        private bool OracleDatabaseExists()
        {
            using (System.Data.IDbConnection conn = _dbf.Create("master"))
            {
                conn.Open();
                using (System.Data.IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select count(*) from user_tables";
                    object o = cmd.ExecuteScalar();
                    int i = 0;
                    try { i = Convert.ToInt32(o); }
                    catch { }
                    return i > 0;
                }
            }
        }

        private void CreateDatabase()
        {
            if (!string.IsNullOrEmpty(_dbf.DatabaseName) && !DatabaseExists())
            {
                Console.Out.Write("Creating database...");
                if (_dbf.IsOracleProvider)
                    OracleCreateDatabase();
                SqlServerCreateDatabase();
            }
        }

        private void SqlServerCreateDatabase()
        {
            Console.Out.WriteLine("SQL Server");
            using (System.Data.IDbConnection conn = _dbf.Create("master"))
            {
                conn.Open();
                using (System.Data.IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "CREATE DATABASE " + _dbf.DatabaseName;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void OracleCreateDatabase()
        {
            Console.Out.WriteLine("Oracle");
        }

        private void CreateSchema()
        {
            Console.Out.WriteLine("Creating Schema");
            string script = _dbf.IsOracleProvider ? "KPICreateSchemaOracle.sql" : "KPICreateSchema.sql";
            RunScript(script);
        }

        private void PopulateData()
        {
            Console.Out.WriteLine("Populating Data");
            RunScript("KPIPopulateData.sql");
        }

        private void DropSchema()
        {
            Console.Out.WriteLine("Dropping Schema");
            string script = _dbf.IsOracleProvider ? "KPIDropSchemaOracle.sql" : "KPIDropSchema.sql";
            RunScript(script);            
        }

        private void DropDatabase()
        {
            if (!string.IsNullOrEmpty(_dbf.DatabaseName))
            {
                Console.Out.Write("Dropping database...");

                if (_dbf.IsOracleProvider)
                    OracleDropDatabase();
                SqlServerDropDatabase();
            }
        }

        private void SqlServerDropDatabase()
        {
            Console.Out.WriteLine("SQL Server");
            using (System.Data.IDbConnection conn = _dbf.Create("master"))
            {
                conn.Open();
                using (System.Data.IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DROP DATABASE " + _dbf.DatabaseName;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void OracleDropDatabase()
        {
            Console.Out.WriteLine("Oracle");
        }

        private void RunScript(string scriptfile)
        {
            string scriptcmds = ReadScript(scriptfile);

            string[] commands = scriptcmds.Split(new string[] { "GO", "Go", "gO", "go" }, StringSplitOptions.RemoveEmptyEntries);
            if (commands == null || commands.Length < 2)
                commands = scriptcmds.Split(';');

            using (System.Data.IDbConnection conn = _dbf.Create())
            {
                conn.Open();

                foreach (string command in commands)
                {
                    if (!string.IsNullOrEmpty(command) && !command.Equals("go", StringComparison.InvariantCultureIgnoreCase) && !command.Equals(System.Environment.NewLine) && !command.Equals(";"))
                    {
                        //Console.Out.WriteLine(command);
                        try
                        {
                            using (System.Data.IDbCommand cmd = conn.CreateCommand())
                            {
                                cmd.CommandType = System.Data.CommandType.Text;
                                cmd.CommandText = command;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            while (ex != null)
                            {
                                Console.Error.WriteLine(ex.Message);
                                ex = ex.InnerException;
                            }
                        }
                    }
                }
            }
        }

        private string ReadScript(string scriptfile)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourcefile = //asm.GetName().Name + 
                    "Tests.Data." + scriptfile;

            using (System.IO.Stream stream = asm.GetManifestResourceStream(resourcefile))            
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        #endregion
    }   
}
