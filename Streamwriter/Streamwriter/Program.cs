using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Streamwriter.txt";
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter Writer = new StreamWriter(file))
                {
                    int[] arr = { 1, 2, 34, 5 };
                    foreach(var item in arr)
                    {
                        Writer.WriteLine(item +" ");
                    }
                    Console.ReadKey();

                }

                
                


                

                    

                
            }
        }
    }
}
