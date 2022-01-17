using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileExists
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:/.net.txt";
            string path2 = @"D:/net2.txt";
            File.Copy(path, path2,true);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
