using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:assignment.txt";
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string line = "";
                    int count = 0;
                    while(count<=5)
                    {
                        line = reader.ReadLine();
                        string[] t1 = line.Split(':');
                        //string[] t2 = line.Split(':');

                        if(t1.Length>1)
                        {
                            Console.Write(t1[0]);
                            Console.Write("           ");
                          
                            count++;  
                        }
;                       
                      
                    }
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] t2 = line.Split(':');
                        Console.Write(t2[1]);
                        Console.Write("                 ");

                    }
                }
                Console.ReadLine();

                

            }
        }
    }
}
    



