using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSum
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            Console.WriteLine("Write the First Range Number");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the Last Range Number");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum = oddNumbersSum + currentValue;
                }
                currentValue++;
            }

            Console.WriteLine("Quantity of odd numbers: " + oddNumbersCount);
            Console.WriteLine("Quantity of even numbers: " + evenNumbersCount);
            Console.WriteLine("Sum of odd numbers: " + oddNumbersSum);
            Console.WriteLine("Sum of even numbers: " + evenNumbersSum);
            Console.ReadLine();
        }
    }
}
