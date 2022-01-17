using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    class Cls
    {
        public string str;
        public int num;

        public static Cls operator +(Cls obj1, Cls obj2)
        {
            Cls obj3 = new Cls();
            obj3.str = obj1.str + obj2.num;
            return obj3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cls obj1 = new Cls();
            obj1.str = "sai";
            obj1.num = 3;
            Cls obj2= new Cls();
            obj2.str = "sai";
            obj2.num = 3;

            Cls obj3 = new Cls();
            obj3 = obj1 + obj2;
            Console.WriteLine(obj3.str);
            Console.ReadLine();

        }
    }
}
