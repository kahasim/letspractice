using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----Dictionary---------");
            Dictionary<string,string> EmployeeList= new Dictionary<string, string>(5);
            EmployeeList.Add("Benjamin", "Texas");
            EmployeeList.Add("Trek", "London");
            EmployeeList.Add("Carlos", "Florida");
            EmployeeList.Add("Adwin", "Texas");

            foreach(KeyValuePair<string,string> employee in EmployeeList)
            {
                Console.WriteLine("key: {0}, Value: {1}", employee.Key, employee.Value);
            }

            EmployeeList["Adwin"] = "Mexico";
            //Not exist add then
            EmployeeList["Dione"] = "Mexico";

            Dictionary<string, string>.KeyCollection keys = EmployeeList.Keys;
            foreach(var key in keys)
            {
                Console.WriteLine("Key: {0}", key);
            }

            if (EmployeeList.ContainsKey("Dione"))
            {
                Console.WriteLine("Found");
            }
            else
            {


            }
            var list = EmployeeList.Keys.ToList();
            list.Sort();
            int i = 0;
            Console.WriteLine("Assignment on arrays and list");

            int[] numbers = new int[5] { 1, 2, 3, 4, 1 };
            List<int> mylist = new List<int>() { 1, 2, 3, 4 };
            mylist = test(mylist);
            mylist = test2(mylist);

            Console.WriteLine("\n\nThe count of the list of integers is: {0}\n\n", numbers.Length);
            foreach (var n in mylist)
            {
                Console.Write("" + n.ToString() +" ");
            }


            Console.WriteLine("\n\nWhere it checks if the same:");
             if (numbers[0] == numbers[4])
            { Console.WriteLine("The first and last are the same."); }
            else
                Console.WriteLine("Not the same");
                    
            String twochars = numbers[0].ToString() + numbers[1].ToString() ;
            Console.WriteLine(twochars + "\n");

          
            //for (int x = 0; x < numbers.Length; x++)
            foreach(var number in numbers)
            {
                i += number;
            }
            Console.WriteLine(i + "\n\n");

     
            foreach (var n in mylist)
            {
                Console.Write("" + n.ToString() + " ");
            }

            checkPrime();
            Console.WriteLine("\n\n");

            Console.WriteLine("Please write a string to check only upper and lower case character: ");
            string casecheck = Console.ReadLine();
            string regex = "^(?=.*[a-z])(?=."
                   + "*[A-Z]).+$";
            // Compile the ReGex
            Regex p = new Regex(regex);
            if (casecheck == null)
            {
                Console.Write("No");
            }
            Match m = p.Match(casecheck);
            if (m.Success)
                Console.Write("Yes\n\n");
            else
                Console.Write("No\n\n");

            Console.WriteLine("\nMultiply array values by the array length");
            for(int x = 0; x < numbers.Length; x++)
            {
                Console.WriteLine(numbers[x] * numbers.Length);
            }

            Console.WriteLine("Check if values within the array is odd");
            foreach (var number in numbers) {
                if (number % 2 != 0)
                {
                    Console.WriteLine("{0} is a odd number", number);
                }
                    }
            Console.WriteLine();
            var hashstr = new List<string>(){
                "#one#",
                "#two#",
                "#three#",
                "#four#",
                "#five#"
            };
            foreach (String hs in hashstr)
            {
                Console.Write($"{hs}");
            }
            Console.WriteLine("\n");
            var intlist = new List<int>(){
              1,2,3,4
            };

            foreach (int il in intlist)
            {
                Console.Write($"{il*3} ");
            }
            Console.ReadKey();

            static List<int> test(List<int> nums)
            {
                //return from .select
                IEnumerable<int> doubled = nums.Select(x => x *= 5);
                return doubled.ToList<int>();
            }

            static List<int> test2(List<int> nums)
            {
                //return from .select
                IEnumerable<int> doubled = nums.Select(x => x *= x);
                return doubled.ToList<int>();
            }
            Console.WriteLine("\n\n");
            
            void checkPrime()
            {
                Console.Write("Enter a Number : ");
                int number = int.Parse(Console.ReadLine());
                bool IsPrime = true;
                for (int i = 2; i < number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.Write("Number is Prime.\n");
                }
                else
                {
                    int termination = 0;
                    Console.Write("Number is not Prime.\n");
                    for (int i = number; termination < 1; i++)
                    {
                        int counter = 0;
                        for (int j = 2; j <= i / 2; j++)
                        {
                            if (i % j == 0)
                            {
                                counter++;
                                break;
                            }
                        }

                        if (counter == 0 && i != 1)
                        {
                            Console.Write("The next prime number is {0} ", i);
                            termination++;
                        }
                    }
                }
            }
        }
    }
}
