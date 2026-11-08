using System;
using System.Runtime.CompilerServices;

namespace LIFO
{
    class Program
    {
        public static void Main(string[] args)
        {
            DisplayThings.operationDisplay();
        }
    }

    public class LIFO
    {
        private object[] stackContainer;
        private int top;

        public LIFO(int size)
        {
            stackContainer = new object[size];
            top = -1;
        }

        public void Push(int item)
        {
            if (top == stackContainer.Length - 1)
            {
                throw new Exception("Stack full!");
            }
            else
            {
                stackContainer[++top] = item;
            }
        }

        public object Pop()
        {
            return -1;
        }

        public object Peek()
        {
            if (top == 0)
            {
                throw new Exception("Stack is empty!");
            }
            else
            {
                for (int i = top; i >=0; i++)
                {
                    Console.WriteLine(stackContainer[i]);
                }
            }
            return -1;
        }

        public void PrintStack()
        {
            
        }
    }

    class DisplayThings
    {
        public static void operationDisplay()
        {
            Console.WriteLine("Choose from the following operations");
            Console.WriteLine("\t[1] Enter new URL");
            Console.WriteLine("\t[2] Navigate backwards");
            Console.WriteLine("\t[3] Navigate forwards");
        }

        public static void EnterDecision()
        {
            Console.Write("Enter an operation: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
            {
                LIFO.// make this shit static or else face the consequences
            }
    }

}