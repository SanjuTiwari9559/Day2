using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace valueTypeAndReferenceType
{
    public class Person
    {
      public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            increment(number);//This is value type 
            Console.WriteLine(number);
            Person person = new Person();
            person.age = 20;
          int newAge= ageIncrement(person);
            Console.WriteLine(newAge);//This is Reference type
        }
        public static void increment(int number)
        {
            number += 20;
        }
        public static int ageIncrement(Person person)
        {
            person.age += 20;
            return person.age;
        }
    }
}
