using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Stacks
{
    interface Istack
    {
        void Push(int a);
        void Pop();
        int Length { get; set; }
    }

    class Child : Istack
    {
        int len;
        public int[] arr= { };
        int i = 0;
        //int Top =0;
        
        public void Push(int a)
        {
            
            try
            {
                if( i < Length)
                {
                    arr.Append(a);
                   
                }
                i++;

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }
        public void Pop()
        {
            try
            {
                
                
                Console.WriteLine("Pop value is:", arr[i]);
                i--;
                
            }

            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }
        public int Length
        {
            set
            {
                if (len<0)
                {
                    Console.WriteLine("enter +ve value");
                }

                this.len = value;
            }
            get
            {
                return len;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Child c = new Child();
            c.Length = int.Parse(Console.ReadLine());
            
            c.Push(1);
            c.Push(2);
            c.Push(3);
            c.Push(4);
            c.Push(5);
            Console.Write("before:", c.arr);
            c.Pop();
            c.Pop();
            Console.WriteLine($"after {c.arr}");
            Console.ReadLine();


        }
    }
}
