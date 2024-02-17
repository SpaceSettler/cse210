
class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return Int32.Parse(_points);
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRep()
    {
        return $"1,{_shortName},{_description},{_points},{_isComplete}";
    }
}