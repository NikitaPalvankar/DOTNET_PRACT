using System.Collections.Generic;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            #region with prop
            //s1.Id = 1;
            //s1.Name = "Nikita";
            //s1.Marks = 70; 
            //s1.Display();
            //Console.WriteLine("--------");
            #endregion



            #region wih ctor
            //Student s2 = new Student(1, "Nikita", 70); 
            //s2.Display();
            //Console.WriteLine("--------");
            //Student s3 = new Student(2, "Sneha", 85);
            //s3.Display();
            //Console.WriteLine("--------"); 
            #endregion


            #region list<Student>
            //| Concept          | Meaning  |
            //| ---------------- | -------- |
            //| `List < Student >`  | Table |
            //| `Student` object | One row |
            //| `Add()`          | Insert |
            //| `foreach`        | Read all |

            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Sunil", 95));
            students.Add(new Student(2, "Sneha", 95));
            students.Add(new Student(3, "Nikita", 70));
            students.Add(new Student(4, "Nikhil", 40));

            foreach (Student s in students)
            {
                s.Display();
                Console.WriteLine("---------");

            }

            #endregion

            

        }
    }
}
