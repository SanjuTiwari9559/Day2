using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Sanjay";
            string str2 = "Tiwari";
            //Cancatination of the string
            string str3 = str1 + " " + str2;
            Console.WriteLine(str3);
            // Find Character from string
            char ch = str1[0];
            Console.WriteLine(ch);
            //Formating string  by using formate method
            string fullName = string.Format("{0} {1}",str1,str2);
            Console.WriteLine(fullName);
            //Verbatim string 
            var text=@"This is Sanjay
                     He is Belongs to Mirzapur
                     He is Talented Person";
            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(text);



        }
    }
}
