using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constuctor_inheritance
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("base defaulf");
        }

        public Base(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
