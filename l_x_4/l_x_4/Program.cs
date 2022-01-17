using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_x_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> L1 = new List<string>();
            Console.WriteLine("enter a value");
            int c = int.Parse(Console.ReadLine());
            string n;
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("enter list values");
                n = Console.ReadLine();
                L1.Add(n);
                //Console.Write(L1[i]);
            }
            foreach (string  item in L1)
            {
                string list = item * 4 ;
                Console.Write(list + " ");
            }
            Console.ReadLine();

        }

    }
   
        
   
}
