using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 1 of Week 3: \n\n");
            Console.WriteLine("***************************************************");
            Console.WriteLine("Problem #1");
            SumMethod Sumobj = new SumMethod();
            Console.WriteLine($"The sum of a integer is: {Sumobj.Sum(23, 24)}");
            Console.WriteLine($"The sum of a Float is: {Sumobj.Sum(23F, 24F)}");
            Console.WriteLine($"The sum of a Double is: {Sumobj.Sum(23D, 24D)}");

            Console.WriteLine("***************************************************");
            Console.WriteLine("Problem #2");
            Console.WriteLine("Default Constructor");
            AllConstructors ConstructorObj = new AllConstructors();
            AllConstructors ConstructorParamObj = new AllConstructors("Paramter");
            //Copying the constructor of First AllConstructor Constructor
            AllConstructors CConstructorObj = new AllConstructors(ConstructorObj);
            AllConstructors.PrivatePrint();
            Console.WriteLine();


            Console.WriteLine("***************************************************");
            Console.WriteLine("Problem #3");
            Dictionary<string, int> employeedict = new Dictionary<string, int>();
            employeedict.Add("Employee1", 40000);
            employeedict.Add("Employee2", 75000);
            employeedict.Add("Employee3", 150000);
            employeedict.Add("Employee4", 250000);
            employeedict.Add("Employee5", 100000);

            foreach (KeyValuePair<string, int> emp in employeedict)
            {
                Console.WriteLine(emp);
                if (emp.Value == 140000)
                {
                    Console.WriteLine("The Tax Deduction is 15%");
                    Console.Write("The Tax Deduction Salary is: ");
                    Console.WriteLine(140000 * .15);
                }
                else if (emp.Value == 75000)
                {
                    Console.WriteLine("The Tax Deduction is 10%");
                    Console.Write("The Tax Deduction Salary is: ");
                    Console.WriteLine(75000 * .1);
                }
                else if (emp.Value == 100000)
                {
                    Console.WriteLine("The Tax Deduction is 10%");
                    Console.Write("The Tax Deduction Salary is: ");
                    Console.WriteLine(100000 * .1);
                }
                else if (emp.Value == 150000)
                {
                    Console.WriteLine("The Tax Deduction is 15%");
                    Console.Write("The Tax Deduction Salary is: ");
                    Console.WriteLine(150000 * .15);
                }
                else if (emp.Value == 250000)
                {
                    Console.WriteLine("The Tax Deduction is 30%");
                    Console.Write("The Tax Deduction Salary is: ");
                    Console.WriteLine(250000 * .3);
                }




            }
        }
    }
}
