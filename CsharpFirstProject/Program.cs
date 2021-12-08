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
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                if (prod is IDigitalProductModal digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left");
                }
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

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();
            output.Add(new PhysicalProductModel { Title = "Nerf Football"});
            output.Add(new PhysicalProductModel { Title = "some T-shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });

            return output;
        }

    }
}
