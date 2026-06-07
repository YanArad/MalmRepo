using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Faculty { get; set; }

    public Student(string name, int age, string faculty)
    {
        Name = name;
        Age = age;
        Faculty = faculty;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Faculty: {Faculty}";
    }
}

class College
{
    public List<Student> Students { get; set; } = new List<Student>();

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void PrintStudents()
    {
        foreach (var student in Students)
        {
            Console.WriteLine(student);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        College college = new College();

        college.AddStudent(new Student("Alice Cohen", 22, "Computer Science"));
        college.AddStudent(new Student("Bob Levi", 24, "Electrical Engineering"));
        college.AddStudent(new Student("Carol Mizrahi", 21, "Mathematics"));

        college.PrintStudents();
    }
}
