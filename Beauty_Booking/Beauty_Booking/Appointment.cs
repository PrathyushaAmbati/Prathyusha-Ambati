using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_Booking
{
    static class Appointment
    {
        static string[] st ;
        public static void Appt(string dt)
        {
            string[] arr = dt.Split(' ');
            string[] arr2 = arr[0].Split('/');

            foreach(string i in arr2)
            {
                 Console.Write(i + " ");

            }
            string[] arr3 = arr[1].Split(':');
            foreach (string i in arr3)
            {
                Console.Write(i + " ");

            }
            Console.ReadLine();
        }

        public static void Had_App(string[] arr,string s)
        {
            if(arr.Equals(s))
            {
                Console.WriteLine("already exist");
            }
    
        }

    }
    
}
