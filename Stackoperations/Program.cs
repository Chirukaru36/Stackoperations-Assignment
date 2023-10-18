using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(6);
            s.Push(1);  
            s.Push(2);
            s.Push("Chiru");
            s.Push("Karunya");
            s.Push(new DateTime(2000, 12, 23));
            s.Push(234.67f);

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============");

            s.Pop();
            foreach(var item in s)
            { 
                Console.WriteLine(item); 
            }
            Console.WriteLine("================");
            Stack s2 = new Stack(s.Count);
            foreach(var item in s2)
            {
                s2.Push(item);
            }

            foreach(var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=========");

            s2.Clear();

            foreach(var item in s2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
