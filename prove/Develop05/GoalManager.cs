using System.IO;

class GoalManager
{

	private List<Goal> _goals = new List<Goal>();
	private int _score = 0;
    private int _dailyGoal = 100;

    public GoalManager()
	{

	}

	public void Start()
	{
		while (true)
		{
            DisplayPlayerInfo();
        }
    }

	public void DisplayPlayerInfo()
	{
		int percentage = _score * 100 / _dailyGoal;
        Console.WriteLine();
		Console.WriteLine($"You have {_score} points.\n\nDaily Goal: {_dailyGoal} {percentage}%\n\nMenu Options:\n  1. Create a New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
		string response = Console.ReadLine();
		switch (response)
		{
			case "1":
				CreateGoal();
				break;
			case "2":
				ListGoalNames();
				break;
			case "3":
				SaveGoal();
				break;
			case "4":
				LoadGoal();
				break;
			case "5":
				RecordEvent();
				break;
			case "6":
				Environment.Exit(0);
				break;
			default:
				break;
		}
    }

	public void ListGoalNames()
	{
		Console.WriteLine("The goals are:");
		foreach (Goal goal in  _goals)
		{
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetDetailsString()}"); ;
		}
	}
	public void ListGoalDetails()
	{
		
	}
	public void CreateGoal()
	{
        Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\n  4. Back\nWhich type of goal would you like to make");
        string goalType = Console.ReadLine();
        switch (goalType)
        {
            case "1":
                Console.WriteLine("What is the name of your goal?");
                string sName = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                string sDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                string sPoints = Console.ReadLine();
                SimpleGoal SG = new SimpleGoal(sName, sDescription, sPoints);
                _goals.Add(SG);
                break;
            case "2":
                Console.WriteLine("What is the name of your goal?");
                string eName = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                string eDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                string ePoints = Console.ReadLine();
				EternalGoal EG = new EternalGoal(eName, eDescription, ePoints);
                _goals.Add(EG);
                break;
            case "3":
                Console.WriteLine("What is the name of your goal?");
                string cName = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                string cDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                string cPoints = Console.ReadLine();
                Console.WriteLine("How many times does this goal need to be accomplished for the bonus?");
                string target = Console.ReadLine();
                Console.WriteLine("What is the bonus for accomplishing it that many times?");
                string bonus = Console.ReadLine();
                ChecklistGoal CG = new ChecklistGoal(cName, cDescription, cPoints, Int32.Parse(target), Int32.Parse(bonus));
                _goals.Add(CG);
                break;
            default:
                break;
        }
    }
	public void RecordEvent()
	{
		Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetDetailsString()}");
        }
		Console.WriteLine("Which goal did you accomplish?");
		int response = Int32.Parse(Console.ReadLine()) - 1;
		int points = _goals[response].RecordEvent();
		_score = points + _score;
		Console.WriteLine($"Congratulations! You have earned {points} points!\nYou now have {_score} points.");

    }
	public void SaveGoal()
	{
        Console.WriteLine("What is the filename for the goal file?");
        string goalFile = Console.ReadLine();
		
            using (StreamWriter outputFile = new StreamWriter(goalFile))
            {
			outputFile.WriteLine(_score);
				foreach (Goal goal in _goals)
				{
					outputFile.WriteLine(goal.GetStringRep());

				}
			}
    }
    public void LoadGoal()
	{
		Console.WriteLine("What is the filename for the goal file?");
		string goalFile = Console.ReadLine();
		string[] lines = System.IO.File.ReadAllLines(goalFile);

		foreach (string line in lines)
		{
			
			string[] parts = line.Split(',');
			if (parts.Length > 1)
			{
                string goalType = parts[0];
                string name = parts[1];
                string desc = parts[2];
                string points = parts[3];

                if (goalType == "1")
                {
					bool isComplete = Convert.ToBoolean(parts[4]);
                    SimpleGoal SG = new SimpleGoal(name, desc, points, isComplete);
                    _goals.Add(SG);
                }
                if (goalType == "2")
                {
                    EternalGoal EG = new EternalGoal(name, desc, points);
                    _goals.Add(EG);
                }
                if (goalType == "3")
                {
                    int target = Int32.Parse(parts[4]);
                    int bonus = Int32.Parse(parts[5]);
					int amountCompleted = Int32.Parse(parts[6]);
                    ChecklistGoal CG = new ChecklistGoal(name, desc, points, target, bonus, amountCompleted);
                    _goals.Add(CG);
                }
            }
			else
			{
				_score = Int32.Parse(line);
			}
		}
	}
}