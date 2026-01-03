using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    internal class Student
    {
        //public int Id;
        //public string Name;
        //public int Marks;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student()
        {
            Id = 0;
            Name = "NA";
            Marks = 0;
        }

        public Student(int id, string name, int marks)
        {
            Id=id;
            Name=name;
            Marks=marks;
        }


        public void Display()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Marks: {Marks}");

        }
    }
}
