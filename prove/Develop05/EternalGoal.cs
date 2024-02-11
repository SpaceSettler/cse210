using System;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return _isComplete;
    }
    public string GetStringRep()
    {

    }
}