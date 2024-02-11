uisng System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
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