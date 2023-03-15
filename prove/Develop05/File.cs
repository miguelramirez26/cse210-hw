class File
{
    // Attributes
    private string _fileName;

    public File()
    {
    }

    // Methods
    public void Save(List<Goal> goals)
    {
        Console.Write("Enter the file name (filename.txt): ");
        _fileName = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(_fileName, true))
        {
            foreach (Goal goal in goals)
            {
                if (goal.getType() != "3")
                {
                    file.WriteLine($"{goal.getType()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetIsComplete()}");
                }

                else

                {
                    file.WriteLine($"{goal.getType()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetCompletedCount()}|{goal.GetRequiredTimes()}|{goal.GetBonus()}|{goal.GetIsComplete()}");
                }
            }
        }

        Console.WriteLine("Your file has been successfully saved.");
    }

    public void Load(ref List<Goal> goals)
    {
        Console.Write("Enter the file name (filename.txt): ");
        _fileName = Console.ReadLine();

        string[] line = System.IO.File.ReadAllLines(_fileName);

        for (int i = 0; i < line.Length; i++)
        {
            string [] column = line[i].Split("|");

            if (column[0] == "1")
            {
                // Goal type | Goal name | Goal description | Points | Bool
                // (int type, string name, string description, int points, bool isComplete)
                Simple simple = new Simple(column[0], column[1], column[2], Convert.ToInt32(column[3]), Convert.ToBoolean(column[4]));

                goals.Add(simple);
            }

            else if (column[0] == "2")
            {
                // Goal type | Goal name | Goal description | Points
                // (int type, string name, string description, int points)
                Eternal eternal = new Eternal(column[0], column[1], column[2], Convert.ToInt32(column[3]));

                goals.Add(eternal);
            }

            else if (column[0] == "3")
            {

                // Goal type | Goal name | Goal description | Points | Required times | Bonus | Completed Count | Bool
                // (int type, string name, string description, int points, int requiredTimes, int bonus, int completedCount, bool isCompleted)
                Checklist checklist = new Checklist(column[0], column[1], column[2], Convert.ToInt32(column[3]), Convert.ToInt32(column[4]), Convert.ToInt32(column[5]), Convert.ToInt32(column[6]), Convert.ToBoolean(column[7]));

                goals.Add(checklist);
            }
        }

        Console.WriteLine("Your file has been successfully loaded.");
    }
}