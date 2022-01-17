using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn2X5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int>();
            Console.WriteLine("enter a value");
            int c = int.Parse(Console.ReadLine());
            int n;
            for(int i=0; i< c; i++)
            {
                Console.WriteLine("enter list values");
                n = int.Parse(Console.ReadLine());
                L1.Add(n);
                //Console.Write(L1[i]);
            }
            foreach(int item in L1)
            {
                int list = ((item) + 2) * 5;
                Console.Write( list +" ");
            }
            Console.ReadLine();
        }
    }
}
