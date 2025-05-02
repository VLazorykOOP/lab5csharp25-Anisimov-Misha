using System;

struct Abiturient
{
    public string LastName;
    public string FirstName;
    public string Patronymic;
    public int BirthYear;
    public int[] ExamScores; // Оцінки вступних іспитів
    public double AverageGrade; // Середній бал атестата

    // Конструктор для зручності
    public Abiturient(string lastName, string firstName, string patronymic, int birthYear, int[] examScores, double averageGrade)
    {
        LastName = lastName;
        FirstName = firstName;
        Patronymic = patronymic;
        BirthYear = birthYear;
        ExamScores = examScores;
        AverageGrade = averageGrade;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Прізвище: {LastName}, Ім'я: {FirstName}, По батькові: {Patronymic}");
        Console.WriteLine($"Рік народження: {BirthYear}");
        Console.WriteLine($"Оцінки вступних іспитів: {string.Join(", ", ExamScores)}");
        Console.WriteLine($"Середній бал атестата: {AverageGrade}");
    }
}

class Program
{
    static void Main()
    {
        Abiturient[] abiturients = new Abiturient[]
        {
            new Abiturient("Іванов", "Іван", "Іванович", 2000, new int[] { 100, 95, 85 }, 4.8),
            new Abiturient("Петренко", "Петро", "Петрович", 2001, new int[] { 90, 80, 85 }, 4.5),
            new Abiturient("Сидоренко", "Сидір", "Сидорович", 2002, new int[] { 85, 80, 90 }, 4.6)
        };

        // Видалити елемент з певним індексом
        Console.WriteLine("Введіть номер елемента для видалення (0, 1, 2): ");
        int indexToDelete = int.Parse(Console.ReadLine());
        abiturients = RemoveAbiturient(abiturients, indexToDelete);

        // Додати елемент після певного прізвища
        Console.WriteLine("Введіть прізвище для додавання нового абітурієнта після: ");
        string lastNameToAddAfter = Console.ReadLine();
        abiturients = AddAbiturientAfterLastName(abiturients, lastNameToAddAfter, new Abiturient("Новак", "Олександр", "Олександрович", 2000, new int[] { 95, 88, 92 }, 4.7));

        // Вивести всі елементи
        foreach (var abiturient in abiturients)
        {
            abiturient.ShowInfo();
            Console.WriteLine();
        }
    }

    static Abiturient[] RemoveAbiturient(Abiturient[] abiturients, int index)
    {
        if (index < 0 || index >= abiturients.Length)
            return abiturients; // Якщо індекс не коректний, повертаємо без змін
        Abiturient[] newAbiturients = new Abiturient[abiturients.Length - 1];
        for (int i = 0, j = 0; i < abiturients.Length; i++)
        {
            if (i != index)
            {
                newAbiturients[j++] = abiturients[i];
            }
        }
        return newAbiturients;
    }

    static Abiturient[] AddAbiturientAfterLastName(Abiturient[] abiturients, string lastName, Abiturient newAbiturient)
    {
        int index = Array.FindIndex(abiturients, a => a.LastName == lastName);
        if (index == -1) return abiturients; // Якщо прізвище не знайдено, повертаємо без змін

        Abiturient[] newAbiturients = new Abiturient[abiturients.Length + 1];
        for (int i = 0, j = 0; i < abiturients.Length; i++, j++)
        {
            if (i == index + 1)
            {
                newAbiturients[j++] = newAbiturient;
            }
            newAbiturients[j] = abiturients[i];
        }
        return newAbiturients;
    }
}
