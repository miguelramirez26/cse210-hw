using System;

class Program
{
    static void Main(string[] args)
    {
        // totalPoints
        // goal list
        int _userInput = 0;
        int totalPoints = 0;
        int _points = 0;
        List<Goal> goals = new List<Goal>();

        while (_userInput != 6)
        {   
            Console.WriteLine($"\nYou have {totalPoints} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu (1-6): ");
            _userInput = Convert.ToInt32(Console.ReadLine());

            if (_userInput == 1)
            {
                // Prompt userfor type of goal (may need to list the types with a number) 
                // Have if statments for each type
                // Prompt user for neccessary paramater info
                // int name = (GET name)... type, description, points
                // construct the object
                // store the object in the list
                Console.WriteLine("Please enter the type of goal: ");
                Console.WriteLine("Please select the type of goal from the following options:");
                Console.WriteLine("  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
                Console.Write("Enter your choice (1-3): ");
                string _type = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                string _name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string _description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                _points = Convert.ToInt32(Console.ReadLine());

                if (_type == "1") 
                {
                    Simple simple = new Simple(_type, _name, _description, _points);
                    goals.Add(simple);
                }
                
                else if (_type == "2")
                {
                    Eternal eternal = new Eternal(_type, _name, _description, _points);
                    goals.Add(eternal);

                }
                
                else if (_type == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int _requiredTimes = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int _bonus = Convert.ToInt32(Console.ReadLine());

                    Checklist checklist = new Checklist(_type, _name, _description, _points, _requiredTimes, _bonus);
                    goals.Add(checklist);
                }
                
                else
                {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                }
            }

            else if (_userInput == 2)
            {
                // Use for loop to display goal (using getters)
                if (goals.Count == 0)
                {
                    Console.WriteLine("There are no goals to show.");
                }
                
                else
                {
                    Console.WriteLine("The goals are:");

                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.Write((i+1) + ". ");
                        goals[i].Display();
                    }
                }
            }

            else if (_userInput == 3)
            {
                File file = new File();
                file.Save(goals);
            }

            else if (_userInput == 4)
            {
                File file = new File();
                file.Load(ref goals);
            }

            else if (_userInput == 5)
            {
                // First check for goals that are NOT complete
                // Display goals
                // GET user desired goal
                // Call record method
                List<Goal> incompleteGoals = new List<Goal>();

                int x = 1;

                foreach (Goal goal in goals)
                {
                    if (goal.GetIsComplete() == false)
                    {
                        incompleteGoals.Add(goal);
                        Console.Write($"{x} ");
                        goal.Display();
                        x++;
                    }
                }

                if (incompleteGoals.Count() == 0)
                {
                    Console.WriteLine("There are no incomplete goals.");
                }
                else
                {
                    Console.Write("Select the goal you want to record: ");
                    int _option = Convert.ToInt32(Console.ReadLine());
                    _option -= 1;

                    incompleteGoals[_option].Record(ref totalPoints);
                }
            }

            else if (_userInput == 6)
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
            }
        }
    }
}