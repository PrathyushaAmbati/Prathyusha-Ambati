using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Beauty_Booking

{
    //class properties
    //{
    //    public string Date { get; set; }
    //}
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            Console.WriteLine("enter a value");
            //properties p1 = new properties()
            //{
            //    Date = Console.ReadLine()
            //};

            string s1 = Console.ReadLine();
            
            //data.Add(s1);
            Appointment.Had_App(data.ToArray(),s1);
            
             
            Appointment.Appt(s1);

            Console.ReadLine();
        }
    }
}
