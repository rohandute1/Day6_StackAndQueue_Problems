using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Stack_Queue_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue problems");
            bool continueExecution = true;
            
            while (continueExecution)
            {
                Console.WriteLine("Choose Stack or Queue");
                Console.WriteLine("1.Stack operation\n2.Queue operations");

                int option = Convert.ToInt32(Console.ReadLine());

                switch(option) 
                {
                    case 1:
                        LinkedListStack stack = new LinkedListStack();

                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);

                        // Pop elements from the stack until it is empty
                        Console.WriteLine("Popped elements:");
                        while (!stack.IsEmpty())
                        {
                            int poppedElement = stack.Pop();
                            Console.WriteLine(poppedElement);
                        }
                        break;

                    case 2:
                        LinkedListQueue customQueue = new LinkedListQueue();

                        customQueue.Enqueue(56);
                        customQueue.Enqueue(30);
                        customQueue.Enqueue(70);

                        Console.WriteLine("Dequeue: " + customQueue.Dequeue());
                        Console.WriteLine("Dequeue: " + customQueue.Dequeue());
                        Console.WriteLine("Dequeue: " + customQueue.Dequeue());

                        break;
                }
                Console.WriteLine("Do you want to continue.(yes/no)");
                string userInput = Console.ReadLine();  
                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }
            Console.ReadLine();
        }
    }
}
