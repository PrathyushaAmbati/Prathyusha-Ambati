using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"E:\assignment.txt";
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader reader = new StreamReader(file))
                {
                    string line = "";
                    int count = 0;

                    while (count <= 5)
                    {
                        line = reader.ReadLine();
                        string[] t1 = line.Split(':');


                        if (t1.Length > 1)
                        {
                            Console.Write(t1[0]);
                            Console.Write("                 ");

                            count++;
                        }
                    }
                    Console.WriteLine();
                    string line1 = "";
                    int count1 = 0;


                    while ((line1 =reader.ReadLine()) != null )
                    { 
                        String[] t2 = line1.Split(':');
                        
                        if (t2.Length > 1)
                        {

                            
                            Console.Write(t2[1]);
                            Console.Write("                ");
                            count1++;
                            if (count1 == 6)
                            {
                                Console.WriteLine();
                                count1 = 0;
                            }
                            
                        }
                    }
                    Console.ReadLine();
                }
            }

        }
    }
}
