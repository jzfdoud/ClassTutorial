using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTutorial
{
    class Student
    {
        public string Name;
        public string Address;
        public decimal GPA;
        public string Major;
        public bool Graduated = false;

        public void Print() {
            Console.Write($"Name: {Name}, GPA: {GPA}, Major: {Major}");
            Console.WriteLine($", Graduated: {Graduated}");
        }

        public void HasGraduated()
        {
            Graduated = true;
        }

        public void NewGPA(decimal GPA)
        {
            this.GPA = GPA;
        }

        public string UppercaseName()
        {
            return Name.ToUpper();
        }

        // Default Constructor, constructor that takes no params- sort of a special kind of method
        public Student()
        {
            Console.WriteLine("Called default constructor");
        }

        public Student(string name)
        {
            Name = name.ToUpper();
            Console.WriteLine("Called constructor with one parameter");
        }
    }
}
