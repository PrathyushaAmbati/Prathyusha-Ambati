using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Stud
    {
        public int rollno;
        public string name;
        public string course;
        public int FeePaid;
        public Stud(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        public void Payment(int amount)
        {
            FeePaid += amount;

        }

        public int DueFee()
        {
            return TotalFee() - FeePaid;
        }

        public int TotalFee()
        {
            if (course.ToLower()== "asp.net")
            {
                return 3000;
            }
            else if (course.ToLower() == "c#")
            {
                return 2000;
            }
            return 0;
        }

        public void Print()
        {
            Console.WriteLine("Student name:" + name);

            Console.WriteLine("Roll no:" + rollno);

            Console.WriteLine("course :" + course);

            Console.WriteLine("Total fee:" + TotalFee());

            Console.WriteLine("Fee paid:" + FeePaid);

            Console.WriteLine("Due amount:" + DueFee());
        }

    }
}
