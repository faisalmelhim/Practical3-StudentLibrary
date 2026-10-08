using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StudentLibrary
{
    public class Student
    {
        private int student_id;
        private string name;
        private int age;
        private static int studentCount = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Student_id
        {
            get { return student_id; }
        }

        public static int StudentCount
        {
            get { return studentCount; }
        }

        public Student()
        {
            this.Name = "John Doe";
            this.Age = 16;
            this.student_id = studentCount++;
        }

        public Student(string name, int age)

        {
            this.Name = name;
            this.Age = age;
            this.student_id = studentCount++; 
            }

        public void Display()
        {
            Console.WriteLine(student_id);
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

        public int GetOlder()
        {
            return age = age + 1;

        }
        }

    }

