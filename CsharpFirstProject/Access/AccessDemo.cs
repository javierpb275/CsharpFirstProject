using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFirstProject.Access
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

        //private protected: accessible in the same asembly but not in another assembly
        //private if it is outside the asembly but protected if it is inside.
        private protected void PrivateProtectedDemo()
        {

        }

        //protected: accessible inside the class and its subclasses
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

        //public: accessible everywhere
        public void PublicDemo()
        {
            Console.WriteLine("PublicDemo");
        }
    }
}
