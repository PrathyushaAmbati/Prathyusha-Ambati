using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student_Details s1 = new Student_Details(100, "Prathyusha", "c#");
            Student_Details s2 = new Student_Details(101, "Renuka", "asp.net");

            s1.Payment(1000);
            s2.Payment(500);

            s1.Print();

            Console.WriteLine("-----------------------------");

            s2.Print();

            Console.ReadLine();
        }
    }
}
