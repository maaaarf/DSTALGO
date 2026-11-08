using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using Microsoft.VisualBasic;

namespace AccountManager
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<AccFunc> students = new List<AccFunc>();

            
        }

    }

    class AccFunc
    {

        public int index = -1;        
        private string studentName { get; set; }
        private int idNumber;
        private string programCode;

        private int gradeArraySize { get; set; }
        private double gradePerCourse { get; set; }
        private double highestGrade { get; set; }
        private double lowestGrade { get; set; }
        private double averageGrade { get; set; }

        public AccFunc(string name, int id, string program)
        {
            studentName = name;
            idNumber = id;
            programCode = program;
        }

        public List<string> studentNameArr = new List<string>();
        // public List<int> idNumber = new List<int>();
        // public List<string> programCode = new List<string>();
        // public ArrayList studentAcademicRecord = new ArrayList();

        

        public void GetUserName()
        {
            Console.Write("Student name: ");
            studentNameArr.Add(Console.ReadLine());

        }

        // public void GetUserID()
        // {
        //     Console.Write("ID number: ");
        //     idNumber.Add(Convert.ToInt32(Console.ReadLine()));
        // }

        // public void GetProgramCode()
        // {
        //     Console.Write("Program code (e.g.: BS-CSEC): ");
        //     programCode.Add(Console.ReadLine());
        // }

        public double ComputeAverage()
        {
            return -1;
        }

        public void GetCourseQuantity()
        {
            Console.Write("Number of courses: ");
            gradeArraySize = Convert.ToInt32(Console.ReadLine());
        }

        public void GetUserGrades()
        {
            
        }

        public void GetHighestGrade()
        {
            
        }
        
        public void GetLowestGrade()
        {
            
        }
    }   

    class MenuFunc
    {
        public static void DisplayMenu()
        {
            
        }

        public static void AddUser()
        {
            // AccFunc.GetUserName();
            // AccFunc.GetUserID();
            // AccFunc.GetProgramCode();
        }

        public static void RemoveUser()
        {
            
        }

        public static void ViewUser()
        {
            
        }

        public static void ExitProgram()
        {
            
        }

        public static void loadingVisual() // serves absolutely no purpose whatsoever apart from being cool as fuck
        {
            Console.CursorLeft = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("⠂");
                Thread.Sleep(150);
                Console.Clear();
                Console.WriteLine("⠢");
                Thread.Sleep(150);
                Console.Clear();
                Console.WriteLine("⠰");
                Thread.Sleep(150);
                Console.Clear();
                Console.WriteLine("⠄⠄");
                Thread.Sleep(150);
                Console.Clear();
                Console.WriteLine("⠰");
                Thread.Sleep(150);
                Console.Clear();
                Console.WriteLine("⠔");
                Thread.Sleep(150);
                Console.Clear();
                  
            }
        }

    }
}

// ⠄ ⠔ ⠢ ⠰ ⠂ 



