using System;
using System.Data;

namespace DbManagementStudio.Core
{
   public enum DbType
    {
        SQLite,
        SQLServer
    }
    public class DbConnectionConfig
    {
         public int ID { get; set; }
         public string Name { get; set; }
         public DbType DbType { get; set; }

         
         public string  ConnectionString { get; set; }


    }
}