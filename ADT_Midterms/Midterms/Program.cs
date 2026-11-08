using System;
using System.Collections;
using System.Drawing;
using System.Reflection;

namespace Midterms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Implementing Numeric List ADT ===");
            int declaredSize = DisplayingThings.GetListSize();
            UnderTheHood numberList = new UnderTheHood(declaredSize);

            for (int i = 0; i < declaredSize; i++)
            {
                UnderTheHood.Add(DisplayingThings.EnterNumber(i));
            }

            UnderTheHood.PrintList();

            
        }
    }

    class UnderTheHood
    {
        
        private static int[] numList;
        private static int index;

        public UnderTheHood(int size)
        {
            numList = new int[size];
            index = -1;
        }

        public static void Add(int item)
        {
            numList[++index] = item;
        }

        public static void PrintList()
        {
            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }
        }

        public static void GetSmallest()
        {
            
        }

        public static void GetBiggest()
        {
            
        }

        public static void GetSum()
        {
            
        }

        public static void GetAverage()
        {
            
        }

        public static void BubbleSort()
        {
            
        }

        public static int SearchItem(int item)
        {
            return -1;
        }

        public static void DoesExist()
        {
            
        }
    }

    class DisplayingThings
    {
        public static int GetListSize()
        {
            Console.Write("Please enter the list size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            return size;
        }

        public static int EnterNumber(int index)
        {
            Console.Write($"Enter number {index + 1}: ");
            int valueEntered = Convert.ToInt32(Console.ReadLine());
            return valueEntered;
        }


    }
}