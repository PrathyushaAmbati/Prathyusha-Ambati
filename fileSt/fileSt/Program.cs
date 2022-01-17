using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace fileSt
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:/fileSt.txt";
            //using (FileStream file = new FileStream(path, FileMode.Append,FileAccess.Write,FileShare.Write))
            using (FileStream file = new FileStream(path, FileMode.Append,FileAccess.Write,FileShare.Write))
            {
                //file.WriteByte(65);
                string line = "Sai Prathyusha";
                Console.WriteLine("creaated...");
            }

            Console.ReadLine();

        }
    }
}
