using System;

namespace CsharpFirstProject.InterfaceLesson
{
    internal class PhysicalProductModel : PhysicalProductBase, IProductModel
    {

        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"shipping {Title} to {customer.FirstName} in {customer.City}");
                HasOrderBeenCompleted = true;
            }
        }

    }
}