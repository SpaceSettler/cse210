using System;

public class GoalManager
{

	//private List<Goal> _goals = new List<Goal>;
	private int score;
	
	class GoalManager()
	{

	}

	public void Start()
	{

	}

	public void DisplayPlayerInfo()
	{
        //Console.WriteLine($'You have {score} points.');
		Console.WriteLine("\nMenu Options:\n  1. Create a New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
		string response = Console.ReadLine();
		switch (response)
		{
			case "1":

				break;
			case "2":
				GM.ListGoalNames();
				break;
			case "3":

				break;
			case "4":

				break;
			case "5":

				break;
			case "6":

				break;
			default:

				break;
		}
    }

	public void ListGoalNames()
	{

	}
	public void ListGoalDetails()
	{

	}
	public void CreateGoal()
	{

	}
	public void RecordEvent()
	{

	}
	public void SaveGoal()
	{

	}
	public void LoadGoal()
	{

	}
}