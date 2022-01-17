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
            Stud s1 = new Stud(100, "Prathyusha", "C#");
            Stud s2 = new Stud(101, "renuka", "asp.net");
            s1.Payment(200);
            s2.Payment(500);
            s1.Print();
            Console.WriteLine("-----------------------------");
            s2.Print();
            Console.ReadLine();
        }
    }
}
