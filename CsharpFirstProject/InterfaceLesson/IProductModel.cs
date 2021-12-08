using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFirstProject.InterfaceLesson
{
    internal interface IProductModel
    {
         string Title { get; set; }
         bool HasOrderBeenCompleted { get; }

        void ShipItem(CustomerModel customer);
    }
}
