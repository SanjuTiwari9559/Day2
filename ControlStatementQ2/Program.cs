using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatementQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int number2=Convert.ToInt32(Console.ReadLine());

            findMax(number1, number2);
         //   Console.WriteLine($"Max Number from {number1} and {number2} is {maxNumber}");

        }

        public static void findMax(int number1, int number2)
        {
            if(number1 < number2)
            {
                Console.WriteLine($"From number {number1},{number2} max number is {number2}");
            }
            else

            {
                if (number1 == number2)
                {
                    Console.WriteLine($" From given number {number1},{number2} Both number are Equal");
                }

                else
                    Console.WriteLine($"From number {number1},{number2} max number is {number1}");
     
            }
        }
    }
}
