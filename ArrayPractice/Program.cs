using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;
            arr1[3] = 4;
            arr1[4] = 5;
           foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }
            

        }
    }
}
