using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatementQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter width of Image");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Height of Image");
            int heigth = Convert.ToInt32(Console.ReadLine());
            findOrientation(width, heigth);



        }

        public  static void findOrientation(int width, int heigth)
        {

            if (width > heigth)
            {
                Console.WriteLine("Givan Image is Landscape Image");
            }
            else
            {
                if(width==heigth)
                {
                    Console.WriteLine("This is square Image");
                }
                else
                {
                    Console.WriteLine("This is portrait Image");
                }
            }
        }
    }
}
