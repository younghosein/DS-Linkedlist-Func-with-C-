using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistFunc_Example_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist l = new Linkedlist();
            l.AddAtFirst(74);
            l.AddAtFirst(64);
            l.AddAtFirst(55);
            l.AddAtFirst(48);
            l.AddAtFirst(35);
            l.AddAtFirst(22);
            //l.Print();
            l.AddAtEnd(73);
            //l.FindMaxMin(l.head);
            //l.DelMax(l.head);
            //l.DelMin(l.head);
            Console.WriteLine("\n");
            l.Print();
            //Console.WriteLine("\n");
            l.AddOnSort(54);
            //l.Print();
            Console.WriteLine("\n");
            //l.DelBLast();
            l.Print();

            Console.ReadKey();
        }
    }
}
