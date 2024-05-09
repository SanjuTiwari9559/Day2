// Question Number 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatementPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the value");
            int number = Convert.ToInt32(Console.ReadLine());
            checkValid(number);

        }

        public static void checkValid(int number)
        {
           if(number>=1 && number <= 10)
            {
                Console.WriteLine("Valid Value");
            }
            else
            {
                Console.WriteLine("Invalid Value please inter valid value");
            }
        }
    }
}
