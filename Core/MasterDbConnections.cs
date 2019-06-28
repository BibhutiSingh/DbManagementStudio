using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SQLite;
namespace DbManagementStudio.Core
{
    public static class MasterDbConnections
    {
        private static Dictionary<int, IConnectionManager> lstConnections=new Dictionary<int, IConnectionManager>();
        private static SQLiteConnection configConnection;
        static MasterDbConnections()
        {
            if (!System.IO.File.Exists("Config.db"))
            {
                using (configConnection)
                {
                    GetConfigConnection();
                    var com = new SQLiteCommand("CREATE TABLE tblConnections (ID INT PRIMARY KEY,Name TEXT,ConnectionString TEXT)", configConnection);
                    com.ExecuteNonQuery();

                    
                }
            
            }
            
            
        }
        private static void GetConfigConnection()
        {
            configConnection=new SQLiteConnection("Data Source=Config.db");
            configConnection.Open();

        }

        public static void AddConnection(DbConnectionConfig dbConfig)
        {

        }

        public static List<DbConnectionConfig> GetAllConnections()
        {
            List<DbConnectionConfig> res=new List<DbConnectionConfig>();
            using (configConnection)
            {
                GetConfigConnection();
                try
                {
                    var  da = new SQLiteDataAdapter("select * from tblConnections", configConnection);
                    var tbl = new DataTable();
                    da.Fill(tbl);
                    foreach (DataRow rw in tbl.Rows)
                    {
                        DbConnectionConfig obj=new DbConnectionConfig();
                        obj.ID=Convert.ToInt32( rw[0].ToString());
                        obj.Name=rw[1].ToString();
                        obj.DbType=(Core.DbType) Convert.ToInt32( rw[2].ToString());
                        obj.ConnectionString=rw[3].ToString();
                        res.Add(obj);
                        
                    }
                }
            catch (Exception)
            { 

             }

            return res;
            }
        }
    }

}