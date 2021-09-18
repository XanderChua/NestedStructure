using System;

namespace NestedStructure
{

        /*struct Employee
        {
           public string employeename;
           public int employeedob;
        }
        struct EmployeeDoB
        {
            public int day, month, year;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nested Structure");
            int noOfEmp = 2;
            int d = 0;
            int m = 0;
            int y = 0;
            Employee[] employees = new Employee[noOfEmp];
            for(int i = 0; i < noOfEmp; i++)
            {
                Console.WriteLine("Name of employee:");
                string empname = Console.ReadLine();
                employees[i].employeename = empname;

                Console.WriteLine("Day of employee bday:");
                d = Convert.ToInt32(Console.ReadLine());
                employees[i].employeedob.day = d;

                Console.WriteLine("Month of employee bday:");
                m = Convert.ToInt32(Console.ReadLine());
                employees[i].employeedob.month = m;

                Console.WriteLine("Year of employee bday:");
                y = Convert.ToInt32(Console.ReadLine());
                employees[i].employeedob.year = y;
            }
        }*/
        struct Test
        {
            public struct TestABC
            {
                public string TeachersName;
                public void Print()
                {
                    Console.WriteLine(TeachersName);
                }
            }
            public string Name;
            public string Grade;
            public int Marks;
            public void Print()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Grade);
                Console.WriteLine(Marks);
            }
        }
        class Program
        {
            public static void Main(string[] args)
            {
                Test test = new Test();
                test.Name = "Nur";
                test.Grade = "A+";
                test.Marks = 95;
                test.Print();
                Test.TestABC testAbc = new Test.TestABC();
                testAbc.TeachersName = "Mithil";
                testAbc.Print();
            }
        }
    }



