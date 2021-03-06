/*2. Create a class called student which has data members like rollno, name, class, SEM, branch,int [] marks=new int marks [5](marks of 5 subjects )
-Write a method called displayresult, which should calculate the average marks
-If marks of any one subject is less than 35 print result as failed
-If marks of all subject is >35 but average is < 50 then also print result as failed
-If avg > 50 then print result as passed.
-Pass the details of student like rollno, name, class, SEM, branch in constructor
-Write a Display Data method to display all values.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student
    {
        private string RollNo;
        string name;
        string cls;
        int sem;
        string branch;

        internal Student()
        {
            Console.WriteLine("Hi Student class here");
        }

        public void GetData()
        {
            Console.Write("Enter RollNo: ");
            RollNo = Console.ReadLine();
            Console.Write("Enter Name:");
            name = Console.ReadLine();
            Console.Write("Enter Class:");
            cls = Console.ReadLine();
            Console.Write("Enter Semester:");
            sem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Branch:");
            branch = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Name of the Student = " + name);
            Console.WriteLine("RollNo = " + RollNo);
            Console.WriteLine("Class = " + cls);
            Console.WriteLine("SEM =" + sem);
            Console.WriteLine("Branch = "+ branch);
        }
    }

    class Marks : Student
    {
        protected int[] a = new int[5];

        public void GetMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter Subject {0} Marks:", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void PutMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Marks in subject {0} : {1}", i + 1, a[i]);
            }
        }

        class Result : Marks
        {
            int TotalMarks = 0;
            public void GetResult()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    TotalMarks = TotalMarks + a[i];
                }
            }
            public void DisplayResult()
            {
                int avg = 0;
                avg = TotalMarks / 5;
                
                Console.WriteLine("-----------------RESULT----------------");
                PutData();
                PutMarks();
                Console.WriteLine("Total Marks = " + TotalMarks);
                Console.WriteLine("Average marks ="+avg);
                if (TotalMarks > 35 && avg < 50)
                {
                    Console.WriteLine("Failed");
                }
                else
                    Console.WriteLine("Passed");

            }

            class Program
            {
                static void Main(string[] args)
                {
                    Result result = new Result();
                    result.GetData();
                    result.GetMarks();
                    result.GetResult();
                    result.DisplayResult();
                    result = null;
                    Console.Read();
                }
            }
        }
    }
}
    

  
           
          
