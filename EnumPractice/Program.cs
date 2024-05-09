using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    public enum Days
    {
        Sunaday=1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,

    }
    internal class Program
    {
        static void Main(string[] args)
        {
             var d=Days.Sunaday;
            Console.WriteLine(d);
            var d1= (int)Days.Monday;
            Console.WriteLine(d1);
            var val = 2;
            Console.WriteLine((Days)val);
        }
    }
}
