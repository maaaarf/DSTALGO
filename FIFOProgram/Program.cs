using System;
using System.ComponentModel;

// FIFO IS First in - First out (Queue)
namespace FIFOProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (ADThings.loopCheck())
            {
                ADThings.displayMenu();
            }
        }
    }

    class ADThings
    {
        private static int index = -1;
        static string[] BoundedQueue = new string[5];
        private static bool loopValue = true;
        private static string enqueueItem = "";

        public static bool loopCheck() //helper function to check loop boolean status
        {
            return loopValue;
        }

        public static void displayMenu() //display function to display menu and capture user input
        {
            Console.WriteLine("\n=== FIFO (First in - Last out) Simulator ===");
            Console.Write("\nWhat would you like to do?\n1. View current queue items\n2. Queue an item\n3. Remove an item from queue\n4. Exit\n>>> ");
            int userDecision = Convert.ToInt32(Console.ReadLine());

            switch (userDecision)
            {
                case 1:
                Peek();
                break;

                case 2:
                Enqueue();
                break;

                case 3:
                Dequeue();
                break;

                case 4:
                loopValue = false;
                break;
            }
        }
        public static void Enqueue() // add item to the back of the queue
        {
            if (isFull() == false)
            {
                Console.Write("Enter item to queue: ");
                enqueueItem = Console.ReadLine();
                BoundedQueue[++index] = enqueueItem;
                Console.WriteLine($"Added {enqueueItem}");
                Console.ReadLine();
            }
        }

        public static void Peek() // function to peek in the current queue array. Uses isEmpty() to check if queue is currently empty and will display nothing
        {
            if (isEmpty() == false)
            {
                for (int i = 0; i < index + 1; i++)
                {
                    if (BoundedQueue[i] != "")
                    {
                        Console.WriteLine($"{BoundedQueue[i]} at index {i}");
                    }
                }
                Console.ReadLine();
            }
           
        }

        public static void Dequeue() //remove and return the front item
        {
            if (isEmpty() == false)
            {
                string firstItem = BoundedQueue[0];
                for (int i = 0; i < index; i++)
                {
                    BoundedQueue[i] = BoundedQueue[i + 1];
                }
                Console.WriteLine($"Removed first item from the list: {firstItem}");
                index--;
                // Console.WriteLine($"Current array size: {index + 1}");

                Console.ReadLine();

            }
        }

        public static bool isEmpty() // checks queue if it is empty
        {
            if (index < 0)
            {
                Console.WriteLine("Current queue is empty!");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool isFull() // checks queue if it is full
        {
            if (index == 4)
            {
                Console.WriteLine("Current queue is full!");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}