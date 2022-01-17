using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constuctor
{
    class Person
    {
        public static int age;
        public static string name;

        static Person() // Static constr
        {
            //int a = 1;
            name = " sai";
            age = 21;
            Console.WriteLine("Static cnst");
        }

        public Person() // default cnstr
        {
            Console.WriteLine("default cnstr");
        }

        public static void GetD() //Static method
        {
            Console.WriteLine(name);

            Console.WriteLine(age) ; 

        }

        public void abc() // instant method
        {
            Console.WriteLine(name);
            Console.WriteLine("method");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            //Person.GetD();
            p1.abc();
            Console.ReadLine(); 
        }
    }
}
