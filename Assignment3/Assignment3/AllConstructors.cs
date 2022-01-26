using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class AllConstructors
    {
        public string Example;
        public AllConstructors()
        {
            Console.WriteLine("Default Constructor ");
            Example = Example;
        }

        static AllConstructors()
        {
            Console.WriteLine("Static Constructor ");
        }

        //Private Constructor
        //private AllConstructors()
        //{
        //    //Console.WriteLine("Private Constructor ");
        //}

        public AllConstructors(string a)
        {
            Console.WriteLine("Parameterize Constructor ");
            Example = a;
        }

        //copy constructor
        //public AllConstructors()
        //{

        //}
    }
}
