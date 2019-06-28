using System;

namespace DbManagementStudio.Plugin.SQLite
{
   public class SqliteConnectionManager: Core.IConnectionManager
    {
       public void AddConnection()
       {
           UI.AddConnection frm=new UI.AddConnection();
           frm.ShowDialog(Program.frmMain);
       }
    }
}