
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var days = Days.monday;

            switch (days)
            {
                case Days.monday:
                    Console.WriteLine("Today is monday");
                   break;
                    
             case Days.tuesday:
                    Console.WriteLine("Today is tuesday");
                    break;

            case Days.wednesday:
                    Console.WriteLine("Today is wednesday");
                    break;

            case Days.thursday:  
            Console.WriteLine("Today is thrusday");
                    break;


          case Days.friday:
          Console.WriteLine("Today is friday");
                   break;

         case Days.saturday:
         Console.WriteLine("Today is saturday");
                   break;

         default: Console.WriteLine("There is no other Days present ");
                   break;

            }

        }
    }
}
