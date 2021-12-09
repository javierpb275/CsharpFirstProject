using System;

namespace CsharpFirstProject
{
    internal class SqliteDataAccess : IDataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        public void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft SQL Data");
        }

        public void SaveData(string sql)
        {
            Console.WriteLine("Saving Data to Microsoft SQL Server");
        }
    }
}