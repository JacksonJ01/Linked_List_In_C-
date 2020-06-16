using System;
using System.Threading;

namespace LinkedLists
{
    public class Datas
    {
        public int data;
        public Datas next;

        public Datas(int value)
        {
            data = value;
            next = null;
        }  

        public void AddEnd(int value)
        {
            if(next == null)
            {
                next = new Datas(value); 
            }
            else
            {
                next.AddEnd(value);
            }
        }

        public void AddRest(Datas value)
        {
            if(next == null)
            {
                next = value;
            }
            else
            {
                next.AddRest(value);
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

    public class Stack
    {
        public Datas headNode;

        public Stack()
        {
            headNode = null;
        }

        public void AddData(int value)
        {
            if (headNode == null)
            {
                headNode = new Datas(value);
            }
            else 
            {
                Datas temp = new Datas(value)
                {
                    next = headNode
                };
                headNode = temp;                
            }
            Console.WriteLine("\n[" + headNode.data + "] has been added to the Stack");
        }

        public void RemoveData()
        {
            if(headNode != null)
            {
                Datas temp = headNode;
                headNode = headNode.next;
                Console.WriteLine("\n[" + temp.data + "] has been removed from the Stack");
            }
            else
            {
                Console.WriteLine("\nThere are no values to remove");
            }
        }

        /// I got cocky because it was easy to make the search method
        /// The seperate times I thought the method was good, but then I tested and it partially worked
        /// I feel like I had to cheese the method so many times:
        /// - I had to create 2 extra methods in the Datas class to re-add the values into the headNode
        ///     - Since I set the headNode to null, I had to create another variable to hold the old headNode value.
        ///      - This is not the most efficient way, but I was able to solve a problem I had, which feels good.
        /// But I think its fine now
        
        public void RemoveSpecificData(int value)
        {
            Console.WriteLine("\n...Searching for " + value + " in the list...");
            bool found = Search(value);
            Thread.Sleep(1500);

            if (found)
            {
                Console.WriteLine("\nThe number has been found\n");
                
                if (headNode.data == value)
                {
                    RemoveData();
                    return;
                }
                Datas old_head = headNode;
                Datas temp = headNode;
                Datas rem = headNode;
                headNode = null;
                while (rem.next != null)
                { 
                    if (rem.data == value)
                    {
                        temp.next = temp.next.next;
                        break;
                    }
                    else
                    {
                        temp = rem;
                        rem = rem.next;
                        if (temp == old_head)
                        {
                            headNode = new Datas(temp.data);
                        }
                        else 
                        { 
                            headNode.AddEnd(temp.data);
                        }                      
                    }
                }
                if (rem.next == null)
                {
                    temp.next = null;
                }
                headNode.AddRest(temp.next);
                Console.WriteLine("[" + value + "] has been removed");

            }
            else
            {
                Console.WriteLine("\nThis number is not in the list");
            }
        }

        public bool Search(int value)
        {
            if (headNode != null)
            {
                if(headNode.data == value)
                {
                    return true;
                }
                else
                {
                    Datas temp = headNode.next;
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
                    if (temp.next == null && temp.data == value)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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
            if(headNode != null)
            {
                Console.WriteLine("");
                headNode.Print();
                Console.ReadLine();
            }
        }
    }
}
