using System;

public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string sName, string topic)
    {
        _studentName = sName;
        _topic = topic;
    }
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}