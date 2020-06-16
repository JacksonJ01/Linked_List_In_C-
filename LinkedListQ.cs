using System;
using System.CodeDom.Compiler;
using System.Threading;

namespace LinkedLists
{
    public class Dataq
    {
        public int data;
        public Dataq next;

        public Dataq(int aData)
        {
            data = aData;
            next = null;
        }

        public void AddEnd(int value)
        {
            if (next == null)
            {
                next = new Dataq(value);
            }
            else
            {
                next.AddEnd(value);
            }
        }

        public void Print()
        {
            Console.Write("[" + data + "]");
            if (next != null)
            {
                next.Print();
            }
        }
    }

    public class Queue
    {
        public Dataq headNode;

        public Queue()
        {
            headNode = null;
        }

        public void AddData(int value)
        {
            if (headNode == null)
            {
                headNode = new Dataq(value);
            }
            else
            {
                headNode.AddEnd(value);
            }
            Console.WriteLine("\n[" + value + "] has been added the the Queue");
        }

        public void RemoveData()
        {
            if (headNode != null)
            {
                int removed = headNode.data;
                headNode = headNode.next;
                Console.WriteLine("\n[" + removed + "] has been removed from the Queue");
            }
            else
            {
                Console.WriteLine("\nThere are no values to remove");
            }
        }

        public bool Search(int value)
        {
            if (headNode != null)
            {
                if (headNode.data == value)
                {
                    return true;
                }
                else if (headNode.next != null)
                {
                    Dataq temp = headNode.next;
                    while (temp.next != null)
                    {
                        if (temp.data == value)
                        {
                            return true;
                        }
                        else
                        {
                            temp = temp.next;
                        }
                    }
                    if (temp.data == value)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void ClearAll()
        {
            headNode = null;
        }

        public void Print()
        {
            if (headNode != null)
            {
                Console.WriteLine("");
                headNode.Print();
                Console.ReadLine();
            }
        }
    }
}