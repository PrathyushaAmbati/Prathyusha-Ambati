using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            int j = 0;

            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[10];

            //Read numbers into array
            Console.WriteLine("Enter elements of ARR1 : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            //Read numbers into array
            Console.WriteLine("Enter elements of ARR2 : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            //Merge arr1 and arr2 to arr3
            for (i = 0, j = 0; i < 5; i++)
            {
                Console.Write("j = " +j );
                arr3[j++] = arr1[i];
                Console.WriteLine("arr = {0} ",arr3[i]);
            }
            //for (i = 0; i < 5; i++)
            //{
            //    arr3[j++] = arr2[i];
            //}

            ////Print merged array
            //Console.WriteLine("Elements of ARR3 : ");
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Element[" + (i + 1) + "]: " + arr3[i]);

            //}

            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}