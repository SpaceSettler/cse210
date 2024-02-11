using System;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {

    }
    public string GetDetailsString()
    {

    }
    public string GetStringRep()
    {

    }
}