using System;

// Абстрактний клас Figure
abstract class Figure
{
    // Абстрактні методи для обчислення площі та периметра
    public abstract double GetArea();
    public abstract double GetPerimeter();

    // Метод для виведення інформації про фігуру
    public abstract void ShowInfo();
}

// Клас для прямокутника
class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Реалізація методу обчислення площі
    public override double GetArea()
    {
        return Width * Height;
    }

    // Реалізація методу обчислення периметра
    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
    }

    // Реалізація методу для виведення інформації
    public override void ShowInfo()
    {
        Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {GetArea()}, Perimeter = {GetPerimeter()}");
    }
}

// Клас для кола
class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Реалізація методу обчислення площі
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Реалізація методу обчислення периметра
    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    // Реалізація методу для виведення інформації
    public override void ShowInfo()
    {
        Console.WriteLine($"Circle: Radius = {Radius}, Area = {GetArea()}, Perimeter = {GetPerimeter()}");
    }
}

// Клас для трикутника
class Triangle : Figure
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    // Реалізація методу обчислення площі за формулою Герона
    public override double GetArea()
    {
        double s = (SideA + SideB + SideC) / 2;  // Півпериметр
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    // Реалізація методу обчислення периметра
    public override double GetPerimeter()
    {
        return SideA + SideB + SideC;
    }

    // Реалізація методу для виведення інформації
    public override void ShowInfo()
    {
        Console.WriteLine($"Triangle: SideA = {SideA}, SideB = {SideB}, SideC = {SideC}, Area = {GetArea()}, Perimeter = {GetPerimeter()}");
    }
}

class Program
{
    static void Main()
    {
        // Створення масиву фігур
        Figure[] figures = new Figure[]
        {
            new Rectangle(4, 6),
            new Circle(5),
            new Triangle(3, 4, 5)
        };

        // Виведення інформації про всі фігури
        foreach (var figure in figures)
        {
            figure.ShowInfo();
            Console.WriteLine();
        }
    }
}
