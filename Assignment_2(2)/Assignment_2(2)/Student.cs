using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_2_
{
    class Student : Person
    {
        public Student(string Fname, string Lname, int ID, int[] scores)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.ID = ID;
            this.scores = scores;
        }

        public void calucalates()
        {
            int avg =( scores[0]+scores[1] )/2;
            
            if (avg >= 90)
            {
                Console.WriteLine("Grade = o");
            }
            else if (avg >= 80 && avg < 90)
            {
                Console.WriteLine("Grade = E");
            }
            else if (avg >= 70 && avg < 80)
            {
                Console.WriteLine("Grade = A");
            }
            else if (avg >= 55 && avg < 70)
            {
                Console.WriteLine("Grade = P");
            }
            else if (avg >= 40 && avg < 55)
            {
                Console.WriteLine("Grade = D");
            }
            else
            {
                Console.WriteLine("Grade = T");
            }



        }
    }
}

    


