using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFirstProject.Access
{
    internal class InheritFromAccessDemo : AccessDemo
    {
        public void Test()
        {
            ProtectedDemo();
            InternalDemo();
            
        }
    }
}
