using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class AllConstructors
    {
        private static string Example;
        public string Example1="Example1";

        //Default Constructor
        //Private Constructor prevent variables from being instantiated

        public AllConstructors() { }

        public static void PrivatePrint()
        {
            Console.WriteLine("Print private constructor");
        }
        static AllConstructors()
        {
            Console.WriteLine("Static Constructor ");
            Example = "This is static with no object created";
        }
           

        public AllConstructors(string a)
        {
            Console.WriteLine("Parameterize Constructor ");
            Example = a;
            Console.WriteLine(a);
        }

        //copy constructor
        public AllConstructors(AllConstructors allConstructors)
        {
            Console.WriteLine("Copying Constructor");
            Example = Example1;
        }


    }
}
