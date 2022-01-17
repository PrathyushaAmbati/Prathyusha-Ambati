using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndRef
{
    struct Employee
    {
        public int Salary;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(); //creating a object e in stack
            e.Salary = 5000;
            e.Age = 23;

            Employee e1 = e;    //assigning object e ==> e1 object
            Employee e2 = e;    // assigning object e ==> e2 object
                                // In above steps... 3 different objects are created with different address Location as struct is of value type.
            e.Age = 25;         
            Console.WriteLine("e = {0}",e.Age);
            Console.WriteLine("e1 = {0}",e1.Age);
            Console.WriteLine("e2 = {0}",e2.Age);
            Console.ReadLine();

        }
    }

}
