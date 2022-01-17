using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("prathyusha", "Ambati", 100,new int[] { 50, 80 });
            Console.WriteLine("Name ={0}, {1} ",s1.Fname, s1.Lname);
            Console.WriteLine("ID ={0}",s1.ID);
            s1.calucalates();

            Console.ReadLine();
        }
    }
}
