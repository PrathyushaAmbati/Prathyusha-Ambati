using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
}
