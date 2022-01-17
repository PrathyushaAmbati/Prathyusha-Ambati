using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandsOn
{
    class Program
    {
        public string[] Id;

        static void Main(string[] args)
        {
            string path = @"E:\assignment.txt";
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            StreamReader reader1 = new StreamReader(file);

            while (reader1.Peek() > 0)
            {

                string lines = reader1.ReadLine();
                int Id_c = 0;
                if (lines.StartsWith("Id"))
                    {
                    Id_c++;
                }
            }
                string[] value = lines.Split(':');
                
                Console.ReadLine();
            }
           
            //Console.WriteLine("Id\t\t Source\t\t\t Destination\t\t Date\t\t\t Status \t date");
            //while (reader.Peek() > 0)
            //{
            //    string line = reader.ReadLine();
            //    string[] values = line.Split(':');

            //    if (line != "")
            //    {
            //        if (values.Length > 1)
            //        {
            //            if (line.StartsWith("Date"))
            //            {
            //                string date = values[1].Split(' ')[0];
            //                Console.Write(date + "\t\t");
            //            }
            //            else
            //                Console.Write(values[1] + "\t\t");
            //        }
            //    }
            //    else
            //        Console.WriteLine();
            //}
            //Console.ReadLine();
            //Console.ReadLine();
        }
    }
}

    

