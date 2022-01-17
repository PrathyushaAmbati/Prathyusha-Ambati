using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;

            Console.Write("print elements");
            Console.Write("------------------------");

            Console.Write("input 10 elements");
            for (i=0; i<=10; i++)
            {
                Console.Write("element- {0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("elements are");
            for(i=0; i < 10; i++)
            {
                Console.Write("{0}", arr[i]);
            }
            Console.Write("/n");

        }
    }
}
