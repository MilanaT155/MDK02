using System;

class StudentGrader
{
    static void Main()
    {
        RunProgram();
    }
    
    static void RunProgram()
    {
        Console.WriteLine("=== Оценка студента ===");
        
        string studentName = GetStudentName();
        int mathGrade = GetGrade("математике");
        int languageGrade = GetGrade("языку");
        int programmingGrade = GetGrade("программированию");
        
        double averageGrade = CalculateAverageGrade(mathGrade, languageGrade, programmingGrade);
        
        DisplayResults(studentName, mathGrade, languageGrade, programmingGrade, averageGrade);
        DisplayStudentStatus(averageGrade);
        CheckScholarship(mathGrade, languageGrade, programmingGrade);
    }
    
    static string GetStudentName()
    {
        Console.Write("Введите имя студента: ");
        return Console.ReadLine();
    }
    
    static int GetGrade(string subject)
    {
        Console.Write($"Введите оценку по {subject} (1-5): ");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    static double CalculateAverageGrade(int math, int language, int programming)
    {
        return (math + language + programming) / 3.0;
    }
    
    static void DisplayResults(string name, int math, int language, int programming, double average)
    {
        Console.WriteLine($"\nРезультаты для {name}:");
        Console.WriteLine($"Математика: {math}");
        Console.WriteLine($"Язык: {language}");
        Console.WriteLine($"Программирование: {programming}");
        Console.WriteLine($"Средний балл: {average:F2}");
    }
    
    static void DisplayStudentStatus(double averageGrade)
    {
        if (averageGrade >= 4.5)
        {
            Console.WriteLine("Отличник! ");
        }
        else if (averageGrade >= 3.5)
        {
            Console.WriteLine("Хорошист! ");
        }
        else if (averageGrade >= 2.5)
        {
            Console.WriteLine("Удовлетворительно ");
        }
        else
        {
            Console.WriteLine("Нужно подтянуть знания! ");
        }
    }
    
    static void CheckScholarship(int math, int language, int programming)
    {
        if (math > 3 && language > 3 && programming > 3)
        {
            Console.WriteLine("Студент сохраняет стипендию! ");
        }
        else
        {
            Console.WriteLine("Стипендия под угрозой! ");
        }
    }
}
