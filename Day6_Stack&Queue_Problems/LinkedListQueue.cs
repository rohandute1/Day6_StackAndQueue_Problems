using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Stack_Queue_Problems
{
    class LinkedListQueue
    {
        private class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node front;
        private Node rear;

        public LinkedListQueue()
        {
            front = null;
            rear = null;
        }

        public void Enqueue(int item)
        {
            Node newNode = new Node(item);

            if (front == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int item = front.Data;
            front = front.Next;

            if (front == null)
            {
                rear = null;
            }

            return item;
        }

        public int Peek()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
