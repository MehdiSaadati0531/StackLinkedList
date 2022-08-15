using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedList
{
    class Node 
    {
        public int Value;
        public Node Next;
        public Node Prive;
    }

    public class Stack_LinkedList
    {
        Node head;
        Node top;

        bool IsEmpty()
        {
            if (top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Push(int val)
        {
            if (IsEmpty())
            {
                Node newnode = new Node();
                newnode.Value = val;
                head = newnode;
                top = head;
                head.Next = null;
                head.Prive = null;
            }
            else
            {
                Node newnode = new Node();
                newnode.Value = val;

                top.Next = newnode;
                newnode.Prive = top;
                top = newnode;
            }
        }

        public void Pop() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty!!!");
            }
            else
            {
                Node temp = top.Prive;
                top = null;
                top = temp;
            }
        }

        public void Print() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("there is nothing to print");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.Value);
                    temp = temp.Next;
                }
            }
        }
    }
}
