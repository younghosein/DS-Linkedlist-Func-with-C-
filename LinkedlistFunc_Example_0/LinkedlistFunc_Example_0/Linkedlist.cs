using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistFunc_Example_0
{
    class Linkedlist
    {
        public Node head;

        public void Print()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " . ");
                n = n.next;
            }
        }
        public void AddAtFirst(int nd)
        {
            Node nn = new Node(nd);

            nn.next = head;
            head = nn;
        }
        public void AddAtEnd(int nd)
        {
            Node nn = new Node(nd);

            if (head == null)
            {
                head = new Node(nd);
                return;
            }

            //nn.next = null;

            Node last = head;

            while (last.next.next != null)
            {
                last = last.next;
            }
            Node t = last.next;
            last.next = nn;
            nn.next = t;

        }
        public void DelBLast()
        {
            Node last = head;

            while (last.next.next != null)
            {
                last = last.next;
            }
            int d = last.data;

            Node n = head;
            Node t = null;

            if (n != null && n.data == d)
            {
                head = n.next;
                return;
            }
            while (n != null && n.data != d)
            {
                t = n;
                n = n.next;
            }
            if (n == null)
            {
                return;
            }
            t.next = n.next;
        }
        public void Del(int d)
        {
            Node n = head;
            Node t = null;

            if (n != null && n.data == d)
            {
                head = n.next;
                return;
            }
            while (n != null && n.data != d)
            {
                t = n;
                n = n.next;
            }
            if (n == null)
            {
                return;
            }
            t.next = n.next;
        }
        public void FindMaxMin(Node h)
        {
            Node n = h;
            Node m = h;
            int max = int.MinValue;
            int min = int.MaxValue;
            while (n != null)
            {
                if (n.data > max)
                {
                    max = n.data;
                }
                n = n.next;
            }
            while (m != null)
            {
                if (m.data < min)
                {
                    min = m.data;
                }
                m = m.next;
            }
            Console.Write($"\n\nMax = {max} , Min = {min}");
        }
        public void DelMax(Node hed)
        {
            int max = int.MinValue;

            while (hed != null)
            {
                if (max < hed.data)
                    max = hed.data;
                hed = hed.next;
            }
            int d = max;

            Node n = head;
            Node bn = null;

            if (n != null && n.data == d)
            {
                head = n.next;
                return;
            }

            while (n != null && n.data != d)
            {
                bn = n;
                n = n.next;
            }

            if (n == null)
                return;

            bn.next = n.next;
        }
        public void DelMin(Node hed)
        {
            int min = int.MaxValue;

            while (hed != null)
            {
                if (min > hed.data)
                    min = hed.data;
                hed = hed.next;
            }
            int d = min;

            Node n = head;
            Node bn = null;

            if (n != null && n.data == d)
            {
                head = n.next;
                return;
            }

            while (n != null && n.data != d)
            {
                bn = n;
                n = n.next;
            }

            if (n == null)
                return;

            bn.next = n.next;
        }
        public void AddOnSort(int num)
        {
            Node nn = new Node(num);

            if (head == null)
            {
                head = nn;
            }
            else
            {
                Node n = head;
                Node end = null;
                bool Is = true;
                while (n != null && Is == true)
                {
                    if (n.data > num)//<
                    {
                        Is = false;
                    }
                    else
                    {
                        end = n;
                        n = n.next;
                    }
                }
                if (end == null)
                {
                    nn.next = head;
                    head = nn;
                }
                else
                {
                    nn.next = n;
                    end.next = nn;
                }
            }
        }
    }
}
