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
            List<PhysicalProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (PhysicalProductModel prod in cart)
            {
                prod.ShipItem(customer);
            }

            Console.ReadLine();

        }
        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "pepe",
                LastName = "perez",
                City = "Madrid",
                EmailAddress = "pepe@gmail.com",
                PhoneNumber = "123456789"
            };
        }

        private static List<PhysicalProductModel> AddSampleData()
        {
            List<PhysicalProductModel> output = new List<PhysicalProductModel>();
            output.Add(new PhysicalProductModel { Title = "Nerf Football"});
            output.Add(new PhysicalProductModel { Title = "some T-shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });

            return output;
        }

    }
}
