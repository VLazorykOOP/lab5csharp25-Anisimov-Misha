using System;

record Abiturient(string LastName, string FirstName, string Patronymic, int BirthYear, int[] ExamScores, double AverageGrade);

class Program
{
    static void Main()
    {
        var abiturients = new[]
        {
            new Abiturient("Іванов", "Іван", "Іванович", 2000, new int[] { 100, 95, 85 }, 4.8),
            new Abiturient("Петренко", "Петро", "Петрович", 2001, new int[] { 90, 80, 85 }, 4.5),
            new Abiturient("Сидоренко", "Сидір", "Сидорович", 2002, new int[] { 85, 80, 90 }, 4.6)
        };

        // Видалення елемента
        Console.WriteLine("Введіть номер елемента для видалення (0, 1, 2): ");
        int indexToDelete = int.Parse(Console.ReadLine());
        abiturients = RemoveAbiturient(abiturients, indexToDelete);

        // Додавання елемента після прізвища
        Console.WriteLine("Введіть прізвище для додавання нового абітурієнта після: ");
        string lastNameToAddAfter = Console.ReadLine();
        abiturients = AddAbiturientAfterLastName(abiturients, lastNameToAddAfter, new Abiturient("Новак", "Олександр", "Олександрович", 2000, new int[] { 95, 88, 92 }, 4.7));

        // Виведення абітурієнтів
        foreach (var abiturient in abiturients)
        {
            Console.WriteLine($"Прізвище: {abiturient.LastName}, Ім'я: {abiturient.FirstName}, По батькові: {abiturient.Patronymic}");
            Console.WriteLine($"Рік народження: {abiturient.BirthYear}");
            Console.WriteLine($"Оцінки вступних іспитів: {string.Join(", ", abiturient.ExamScores)}");
            Console.WriteLine($"Середній бал атестата: {abiturient.AverageGrade}\n");
        }
    }

    static Abiturient[] RemoveAbiturient(Abiturient[] abiturients, int index)
    {
        if (index < 0 || index >= abiturients.Length) return abiturients;
        var newAbiturients = new Abiturient[abiturients.Length - 1];
        for (int i = 0, j = 0; i < abiturients.Length; i++)
        {
            if (i != index) newAbiturients[j++] = abiturients[i];
        }
        return newAbiturients;
    }

    static Abiturient[] AddAbiturientAfterLastName(Abiturient[] abiturients, string lastName, Abiturient newAbiturient)
    {
        int index = Array.FindIndex(abiturients, a => a.LastName == lastName);
        if (index == -1) return abiturients;
        var newArray = new Abiturient[abiturients.Length + 1];
        for (int i = 0, j = 0; i < abiturients.Length; i++, j++)
        {
            if (i == index + 1) newArray[j++] = newAbiturient;
            newArray[j] = abiturients[i];
        }
        return newArray;
    }
}
