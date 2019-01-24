using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue;
            string name;
            int age;

            do
            {
                shouldContinue = false;
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter your age");

                //try
                //{
                    age = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine($"Hi {name}, you are {age} years old.");

                    //throw new ArgumentException();

                    Console.WriteLine();
                    Console.WriteLine("Continue? y/n");
                    var input = Console.ReadLine();
                    if (input.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                    {
                        shouldContinue = true;
                    }

                //}
                //catch (FormatException ex)
                //{
                //    Console.WriteLine($"Please enter a valid number for your age.  Let's try this again {name}.");

                //    shouldContinue = true;
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Something went wrong and I don't know what.  Going to sleep now.  So cold...");
                //    Console.ReadLine();
                //    shouldContinue = false;
                //}

            } while (shouldContinue);
        }

        static int AddNumbers(int a, int b)
        {
            int result = b;

            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    result += a;
                }
            }

            return result;
        }

    }
}
