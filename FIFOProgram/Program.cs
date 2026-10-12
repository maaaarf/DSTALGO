using System;
using System.ComponentModel;
using System.IO.Pipelines;
using BankSystem;

namespace FIFOProgram
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            ADThings.Enqueue("apple");
            ADThings.Enqueue("banana");
            ADThings.Enqueue("orange");
            ADThings.Enqueue("grape");
            ADThings.Enqueue("apple");


            ADThings.Peek();
        
        }
    }

    class ADThings
    {
        private static int index = -1;
        static string[] BoundedQueue = new string[5];
        public static string Enqueue(string item) //add item to the back of the queue
        {
            BoundedQueue[++index] = item;
            return $"Added {item}";
        }

        public static void Peek()
        {
            for (int i = 0; i < BoundedQueue.Length; i++)
            {
                if (BoundedQueue[i] != "")
                {
                    Console.WriteLine(BoundedQueue[i]);                
                }
            }
        }

        public static string Dequeue(string item) //remove and return the front item
        {
            for (int i = 0; i < BoundedQueue.Length; i++)
            {
                
            }
            return "Hello world";
        }
    }
}