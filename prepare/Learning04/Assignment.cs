// Base "Assignment" class
class Assignment
{
    // Attributes
    private string _studentName;
    private string _topic;

    // Constructor
    // It receives student name and topic
    public Assignment(string studentName, string topic)
    {
        // Sets member variables
        _studentName = studentName;
        _topic = topic;
    }

    // Getter
    // This method returns the student name
    public string GetStudentName()
    {
        return _studentName;
    }

    // Method for GetSummary()
    // It will return student name and topic
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}