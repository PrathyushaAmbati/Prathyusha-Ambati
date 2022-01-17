using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:/house.txt";
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter Writer = new StreamWriter(file);
            Writer.WriteLine("welcome");

            Console.Write("enter house name");
            string name = Console.ReadLine();

            Console.Write("enter add name");
            string add = Console.ReadLine();

            Console.Write("enter phn");
            int phn = Convert.ToInt32(Console.ReadLine());

            Writer.WriteLine("house" + name);
            Writer.WriteLine("add" + add);
            Writer.WriteLine("phn" + phn);
            Writer.Close();
            file.Close();
            Console.WriteLine("sucess");
        }

        //public void read()
      





        
    }
}
