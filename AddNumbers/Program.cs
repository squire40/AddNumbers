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
            int firstInt, secondInt;

            do
            {
                shouldContinue = false;
                Console.WriteLine("Enter first integer");
                firstInt = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second integer");
                secondInt = int.Parse(Console.ReadLine());

                var result = AddNumbers(firstInt, secondInt);
                Console.WriteLine();
                Console.WriteLine($"Result is {result}");
                Console.WriteLine();
                Console.WriteLine("Continue? y/n");
                var input = Console.ReadLine();
                if (input.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                {
                    shouldContinue = true;
                }
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
