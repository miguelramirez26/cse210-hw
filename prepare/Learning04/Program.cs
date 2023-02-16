using System;

class Program
{
    static void Main(string[] args)
    {
        // Base "Assignment" object
        Assignment assignmentObj = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignmentObj.GetSummary());
        
        // Derived "MathAssignment" class
        MathAssignment mathAssignmentObj = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignmentObj.GetSummary());
        Console.WriteLine(mathAssignmentObj.GetHomeworkList());

        // Derived "WritingAssignment" class
        WritingAssignment writingAssignmentObj = new WritingAssignment("Mary Waters", "Europen History", "The Causes of World War II");
        Console.WriteLine(writingAssignmentObj.GetSummary());
        Console.WriteLine(writingAssignmentObj.GetWritingInformation());
    }
}