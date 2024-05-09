using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatementQ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit");
            int speedlimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter speed of car");
            int carSpeed=int.Parse(Console.ReadLine());
            if(speedlimit>carSpeed)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demeritPoint=(carSpeed- speedlimit) /5;
                if(demeritPoint>=12) {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine($"Number of Demerite point {demeritPoint}");
                }
            }

            ;
        }
    }
}
