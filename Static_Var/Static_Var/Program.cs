using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Var
{
    class Student //no access modifier so by default varibales bcom private
    {
        public int num; // instant variable 
        public string abc;
        public static string scl = "aaaa";

        public void name() // instant method
        {
            string abc = "sds";
            string Fname = this.abc; // this refers to instacne variable 
            Console.WriteLine(Fname); 
        }

        public static string getFee()// static method
        {
            return scl;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.num = 1;
            s1.abc = "sai";
            Console.WriteLine(Student.getFee()); //calling static variable rfom static method
            s1.name();
            Console.WriteLine(s1.num);
            Console.ReadKey();


        }
    }
}
