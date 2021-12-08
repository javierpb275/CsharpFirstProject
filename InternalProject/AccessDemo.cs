using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalProject
{
    public class AccessDemo
    {
        private void Demo()
        {
            PrivateDemo();
        }
        //private: only accessible in the area it was declared
        private void PrivateDemo() 
        {
            Console.WriteLine("PrivateDemo");
        }

        private protected void PrivateProtectedDemo()
        {

        }

        protected void ProtectedDemo()
        {

        }

        protected internal void ProtectedInternalDemo()
        {

        }

        //internal: the entire object (docu: assembly) is the accessible area. 
        //It is the project, because a project creates an assembly.
        //The entire project is the accesible area.
        internal void InternalDemo()
        {
            Console.WriteLine("InternalDemo");
        }

        public void PublicDemo()
        {

        }
    }
}
