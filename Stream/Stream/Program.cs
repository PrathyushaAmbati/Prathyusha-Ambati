using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:/Steam.txt";
            using(StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(DateTime.Now.ToString());
                Console.WriteLine("succcess");
            }
            // read file
            using(StreamReader reader = new StreamReader(path))
            {
                Console.WriteLine("reading");
                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
