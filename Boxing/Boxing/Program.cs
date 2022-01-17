using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            object obj = num;//Boxing
            //int n = obj;
            
            int n1 = (int)obj;//unboxing
            int n2 = Convert.ToInt32(obj);//unboxing

            Console.WriteLine("n1 = " + n1);
            Console.WriteLine( "n2 = " + n2);
            Console.ReadLine();
            
            
        }
    }
}
