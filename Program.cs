using LinkedLists;
using System;
using System.Threading;

namespace LinkedListsInterface
{      
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            Queue myQueue = new Queue();
            while (true)
            {
                Console.Write("Menu" +
                    "\n*Enter the number next to your choice*" +
                    "\n1. Stack" +
                    "\n2. Queue" +
                    "\n3. Exit Program" +
                    "\n>>>");

                int choice;
                while (true)
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (0 < choice && choice < 4)
                        {

                            break;
                        }
                        else
                        {
                            choice /= 0; // Force Fail
                        }
                    }
                    catch
                    {
                        Console.Write("\nChoose between the numbers 1, 2 or 3" +
                            "\n>>>");
                    }
                }
                if (choice == 3)
                {
                    Console.WriteLine("\nAlright. Bye, have a good day");
                    Thread.Sleep(200);
                    return;                                       
                }
            
                int action;
                while (true)
                {
                    Console.Write("\nMenu" +
                    "\n*Enter the number next to your choice*" +
                    "\n1. Add Data" +
                    "\n2. Remove Data" +
                    "\n3. Search" +
                    "\n4. Print" +
                    "\n5. Clear All" +
                    "\n6. Leave This Menu" +
                    "\n>>>");
                    
                    while (true)
                    {
                        try
                        {
                            action = Convert.ToInt32(Console.ReadLine());
                            if (0 < action && action < 7)
                            {
                                break;
                            }
                            else
                            {
                                action /= 0;
                            }
                        }
                        catch
                        {
                            Console.Write("\nChoose betweeen the numbers 1, 2, 3, 4, 5, or 6," +
                            "\n>>>");                       
                        }
                    }
                    if (action == 6)
                    {
                        Console.WriteLine("");
                        break;
                    }
                    switch (action)
                    {
                        case 1:
                            Console.Write("\nWhat number would you like to add to the list?" +
                                "\n>>>");
                            int value;
                            while (true)
                            {
                                try
                                {
                                    value = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                                catch(FormatException)
                                {
                                    Console.Write("\nThat was an invlid entry." +
                                        "\nPlease enter a number");
                                }
                            }
                            if (choice == 1)
                            {
                                myStack.AddData(value);
                            }
                            else
                            {
                                myQueue.AddData(value);
                            }
                            break;
                        case 2:
                            if(choice == 1)
                            {
                                myStack.RemoveData();
                            }
                            else
                            {
                                myQueue.RemoveData();
                            }
                            break;
                        case 3:
                            Console.Write("\nWhat number do you want to search for?" +
                                "\n>>>");
                            int value2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            if (choice == 1)
                            {
                                Console.WriteLine(myStack.Search(value2));
                            }
                            else
                            {
                                Console.WriteLine(myQueue.Search(value2));
                            }
                            break;
                        case 4:
                            if (choice == 1)
                            {
                                myStack.Print();
                            }
                            else
                            {
                                myQueue.Print();
                            }
                            break;
                        case 5:
                            if (choice == 1)
                            {
                                myStack.ClearAll();
                            }
                            else
                            {
                                myQueue.ClearAll();
                            }
                            Console.WriteLine("\nThe list has been cleared");
                            break;
                    }
                    Console.WriteLine("\nPress Enter");
                    Console.ReadLine();
                }
            }
        }        
    }
}
