using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Загальний метод для виведення даних про особу
    public virtual void Show()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Student : Person
{
    public string StudentID { get; set; }
    public string Major { get; set; }

    public Student(string name, int age, string studentID, string major)
        : base(name, age)
    {
        StudentID = studentID;
        Major = major;
    }

    // Перевизначений метод для виведення даних студента
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Student ID: {StudentID}, Major: {Major}");
    }
}

class Lecturer : Person
{
    public string Department { get; set; }
    public string Course { get; set; }

    public Lecturer(string name, int age, string department, string course)
        : base(name, age)
    {
        Department = department;
        Course = course;
    }

    // Перевизначений метод для виведення даних викладача
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Department: {Department}, Course: {Course}");
    }
}

class HeadOfDepartment : Lecturer
{
    public int YearsInPosition { get; set; }

    public HeadOfDepartment(string name, int age, string department, string course, int yearsInPosition)
        : base(name, age, department, course)
    {
        YearsInPosition = yearsInPosition;
    }

    // Перевизначений метод для виведення даних завідувача кафедри
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Years in Position: {YearsInPosition}");
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єктів класів
        Person person = new Person("John Doe", 40);
        Student student = new Student("Jane Smith", 20, "S12345", "Computer Science");
        Lecturer lecturer = new Lecturer("Dr. Brown", 45, "Computer Science", "Data Structures");
        HeadOfDepartment head = new HeadOfDepartment("Prof. Green", 50, "Computer Science", "Algorithms", 10);

        // Виведення інформації
        Console.WriteLine("Person Info:");
        person.Show();
        Console.WriteLine();

        Console.WriteLine("Student Info:");
        student.Show();
        Console.WriteLine();

        Console.WriteLine("Lecturer Info:");
        lecturer.Show();
        Console.WriteLine();

        Console.WriteLine("Head of Department Info:");
        head.Show();
    }
}
