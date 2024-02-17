
class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override int RecordEvent()
    {
        return Int32.Parse(_points);
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRep()
    {
        return $"2,{_shortName},{_description},{_points}";
    }
}