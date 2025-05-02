using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Конструктор за замовчуванням
    public Person()
    {
        Console.WriteLine("Person: Default constructor called");
    }

    // Конструктор з параметрами
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine($"Person: Constructor with parameters called - Name: {Name}, Age: {Age}");
    }

    // Конструктор для копіювання
    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
        Console.WriteLine($"Person: Copy constructor called - Name: {Name}, Age: {Age}");
    }

    // Деструктор
    ~Person()
    {
        Console.WriteLine("Person: Destructor called");
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

    // Конструктор за замовчуванням
    public Student() : base()
    {
        Console.WriteLine("Student: Default constructor called");
    }

    // Конструктор з параметрами
    public Student(string name, int age, string studentID, string major)
        : base(name, age)
    {
        StudentID = studentID;
        Major = major;
        Console.WriteLine($"Student: Constructor with parameters called - StudentID: {StudentID}, Major: {Major}");
    }

    // Конструктор для копіювання
    public Student(Student other) : base(other)
    {
        StudentID = other.StudentID;
        Major = other.Major;
        Console.WriteLine($"Student: Copy constructor called - StudentID: {StudentID}, Major: {Major}");
    }

    // Деструктор
    ~Student()
    {
        Console.WriteLine("Student: Destructor called");
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

    // Конструктор за замовчуванням
    public Lecturer() : base()
    {
        Console.WriteLine("Lecturer: Default constructor called");
    }

    // Конструктор з параметрами
    public Lecturer(string name, int age, string department, string course)
        : base(name, age)
    {
        Department = department;
        Course = course;
        Console.WriteLine($"Lecturer: Constructor with parameters called - Department: {Department}, Course: {Course}");
    }

    // Конструктор для копіювання
    public Lecturer(Lecturer other) : base(other)
    {
        Department = other.Department;
        Course = other.Course;
        Console.WriteLine($"Lecturer: Copy constructor called - Department: {Department}, Course: {Course}");
    }

    // Деструктор
    ~Lecturer()
    {
        Console.WriteLine("Lecturer: Destructor called");
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

    // Конструктор за замовчуванням
    public HeadOfDepartment() : base()
    {
        Console.WriteLine("HeadOfDepartment: Default constructor called");
    }

    // Конструктор з параметрами
    public HeadOfDepartment(string name, int age, string department, string course, int yearsInPosition)
        : base(name, age, department, course)
    {
        YearsInPosition = yearsInPosition;
        Console.WriteLine($"HeadOfDepartment: Constructor with parameters called - YearsInPosition: {YearsInPosition}");
    }

    // Конструктор для копіювання
    public HeadOfDepartment(HeadOfDepartment other) : base(other)
    {
        YearsInPosition = other.YearsInPosition;
        Console.WriteLine($"HeadOfDepartment: Copy constructor called - YearsInPosition: {YearsInPosition}");
    }

    // Деструктор
    ~HeadOfDepartment()
    {
        Console.WriteLine("HeadOfDepartment: Destructor called");
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
        Console.WriteLine("Creating Person...");
        Person person = new Person("John Doe", 40);
        Console.WriteLine();

        Console.WriteLine("Creating Student...");
        Student student = new Student("Jane Smith", 20, "S12345", "Computer Science");
        Console.WriteLine();

        Console.WriteLine("Creating Lecturer...");
        Lecturer lecturer = new Lecturer("Dr. Brown", 45, "Computer Science", "Data Structures");
        Console.WriteLine();

        Console.WriteLine("Creating HeadOfDepartment...");
        HeadOfDepartment head = new HeadOfDepartment("Prof. Green", 50, "Computer Science", "Algorithms", 10);
        Console.WriteLine();

        Console.WriteLine("Creating Student (Copy)...");
        Student studentCopy = new Student(student);
        Console.WriteLine();

        Console.WriteLine("End of program.");
    }
}
