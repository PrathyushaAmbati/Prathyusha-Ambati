using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
  What is Boxing?
    Implicit convertion of a value type to a reference type is called Boxing.
    
   What is Unboxing?
    Explicit conversion of same reference type (which is beging created by Boxing),back to a value type
    is called Unboxing.
 */
namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10; //value type
            object obj = num;// Boxing
            int num2 = (int)obj; //Unboxing
            int n = Convert.ToInt32(obj);
            Console.WriteLine(n);
            Console.ReadLine();
            
        }
    }
}
