using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class StudentAndTeacher
    {
        static void main()
        {
            bool debug = false;


            //create a person and make it say hello
            person myPerson = new person();
            myPerson.Greet();

            //create a student set age =21 greet and disply age
            Student myStudent = new Student();
            myStudent.Greet();
            myStudent.SetAge(21);
            myStudent.ShowAge();

            // teacher age=30 greet n expalin
            Teacher MyTeacher = new Teacher();
            MyTeacher.Greet();
            MyTeacher.SetAge(31);
            
            MyTeacher.Explain();

            if (debug)
                Console.ReadLine();

        }
    }
}
