using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();

        MathAssignment mathHw = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathHw.GetSummary());
        Console.WriteLine(mathHw.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingHw = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingHw.GetSummary());
        Console.WriteLine(writingHw.GetWritingInformation());
    }
}