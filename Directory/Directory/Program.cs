using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //String path = @"D:/newdic";
            //String path2 = @"D:/newdic2";
            String path3 = @"D:/rajamouli phots";
            DirectoryInfo dir = new DirectoryInfo(path3);
            DirectoryInfo[] dir1 = dir.GetDirectories();
            foreach (var item in dir1)
            {
                Console.WriteLine(item);
            }
            //dir.Delete(true); // by default Delete value will be false 4 
            //dir.MoveTo(path2); 3
            //dir.Create(); 1
            //dir.CreateSubdirectory("Another dic"); 2
            //Console.WriteLine("deleted");
            Console.ReadKey();

            

        }
    }
}
