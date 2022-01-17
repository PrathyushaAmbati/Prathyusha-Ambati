using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employe> empList = new List<Employe>();

            //Employe emp1 = new Employe()
            //{
            //    age = 21,
            //    name = "sai"
            //};

            Employe emp2 = new Employe()
            {
                //Console.WriteLine("enter");
                age = int.Parse(Console.ReadLine()),
                name=Console.ReadLine()
            };

            //empList.Add(emp1);
            empList.Add(emp2);

            foreach(Employe i in empList)
            {
                Console.WriteLine("emp age{0} emp name {1}", i.age,i.name);
            }
            Console.ReadLine();

        }
    }
}
