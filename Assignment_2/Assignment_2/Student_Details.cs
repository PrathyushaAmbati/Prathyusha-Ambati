using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Student_Details
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public int FeePaid { get; set; }
        public string course { get; set; }

        public Student_Details(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        public int TotalFee
        {
            get
            {
                if (course.ToLower() == "asp.net")
                {
                    return 3000;
                }
                else if (course.ToLower() == "c#")
                {
                    return 2000;
                }
                return 0;

            }

        }

        public int DueFee
        {
            get{return TotalFee - FeePaid; }
            
        }

        public void Payment(int amount)
        {
            FeePaid += amount;
        }

        public void Print()
        {
            Console.WriteLine("Student name:" + name);

            Console.WriteLine("Roll no:" + rollno);

            Console.WriteLine("course :" + course);

            Console.WriteLine("Total fee:" + TotalFee);

            Console.WriteLine("Fee paid:" + FeePaid);

            Console.WriteLine("Due amount:" + DueFee);
        }

    }

}

