using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop
{
    class Lappy
    {
        protected float price;
        protected string RAM;
        protected string HD;
        protected string name;
        protected string processor;
        
       public void Set_price(float n)
       {
            price = n;
       }

        public void Set_name(string n)
        {

            name = n;
        }

        public void Set_processor(string n)
        {
            processor = n;
        }

        public void Set_Ram(string n)
        {
            RAM = n;
        }

        public void Set_HD(string n)
        {
            HD = n;
        }




    }
}
