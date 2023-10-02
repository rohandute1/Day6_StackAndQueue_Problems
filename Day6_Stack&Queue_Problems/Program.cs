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
                Console.WriteLine("1.Stack operation");

                int option = Convert.ToInt32(Console.ReadLine());

                switch(option) 
                {
                    case 1:
                        LinkedListStack stack = new LinkedListStack();

                        // Push elements onto the stack in the specified order
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);

                        // Print the top element
                        int topElement = stack.Peek();
                        if (topElement != -1)
                        {
                            Console.WriteLine("Top element: " + topElement);
                        }

                        // Pop elements from the stack and print them
                        Console.WriteLine("Popped elements:");
                        int poppedElement;
                        while ((poppedElement = stack.Pop()) != -1)
                        {
                            Console.WriteLine(poppedElement);
                        }
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
