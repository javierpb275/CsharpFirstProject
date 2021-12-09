using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpFirstProject.Access;

namespace CsharpFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            DataAccess da = new SqliteDataAccess();
            da.LoadConnectionString("");
            */
            
            List<DataAccess> databases = new List<DataAccess>()
           {
               new SqlDataAccess(),
               new SqliteDataAccess()
           };

            foreach (var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("demo"));
                /*
                db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                db.SaveData("insert into table");
                */
                Console.WriteLine();
            }
            
            Console.ReadLine();

        }
       

    }
}
