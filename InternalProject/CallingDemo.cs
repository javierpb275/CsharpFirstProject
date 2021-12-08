using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalProject
{
    public class CallingDemo
    {
        private void MakeDemoCalls()
        {
            AccessDemo demo = new AccessDemo();

            demo.InternalDemo();
        }
    }
}
