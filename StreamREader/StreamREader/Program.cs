using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamREader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"E:\assignment.txt";
            using (FileStream file1 = new FileStream(path1, FileMode.Open, FileAccess.Read))
            {


                using (StreamReader reader = new StreamReader(file1))
                {
                    //string[] line = new string[5];
                    //for(int i =0; i<line.Length;i++)
                    //{
                    //    line[i] = reader.ReadLine();
                    //}
                    //foreach(var item in line)
                    //{
                    //    Console.WriteLine(item);
                    //}
                    
                    
                    
                   while ((line = reader.ReadLine()) != null)
                   {
                        Console.WriteLine(line);

                   }
                   Console.ReadLine();
                }

            }
        }
    }
}
