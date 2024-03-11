using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter the Number: ");
            int nb= Int32.Parse(Console.ReadLine());

            int sum = 0, remainder = 0, backupNb = nb;

            while(nb != 0)
            {
                remainder = nb % 10;
                sum += remainder;
                nb /= 10;
            }
            Console.WriteLine("Sum of Digit Number {0} is {1}", backupNb, sum);

            Console.ReadKey();
        }
    }
}
