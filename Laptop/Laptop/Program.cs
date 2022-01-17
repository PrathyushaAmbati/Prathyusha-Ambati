using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop
{
    class Program
    {
        static void Main()
        {
            Lappy obj1 = new Lappy();
            obj1.Set_name("hp");
            obj1.Set_price(40000);
            obj1.Set_Ram("4GB");
            obj1.Set_processor("i5");
            obj1.Set_HD("intel");

            Laptop_prices obj2 = new Laptop_prices();
            obj2.Lap_price();
            obj2.Lap_name();
            obj2.Lap_HD();
            obj2.Lap_Ram();
            obj2.Lap_processor();

            Console.ReadKey();
        }
    }
}
