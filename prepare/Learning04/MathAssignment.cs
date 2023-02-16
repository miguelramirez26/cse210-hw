// Derived "MathAssingment" class
class MathAssignment : Assignment
{
    // New attributes
    private string _textbookSection;
    private string _problems;

    // Constructor receives all four parameters
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method returns text book section and problems
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}"; 
    }
}