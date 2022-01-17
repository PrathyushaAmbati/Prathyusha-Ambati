using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Textwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:/txtwtr.txt";
            using (TextWriter writer = File.CreateText(path))
            {
                writer.WriteLine(DateTime.Now.ToString());
                Console.WriteLine("success");
                writer.Close();
            }
            //reading
            using (TextReader reader = File.OpenText(path))
            {
                Console.Write("reading");
                Console.WriteLine(reader.ReadToEnd());

            }
            Console.ReadKey();

        }

    }
}
