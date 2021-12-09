using System;

namespace CsharpFirstProject.Data
{
    internal class SqlDataAccess : DataAccess
    {

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft SQL Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving Data to Microsoft SQL Server");
        }

    }
}