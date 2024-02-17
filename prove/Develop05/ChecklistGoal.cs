
class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (IsComplete())
        {
            return Int32.Parse(_points) + _bonus;
        }
        return Int32.Parse(_points); 
    }
    public override bool IsComplete()
    {
        return (_amountCompleted == _target);
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) -- Complete";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRep()
    {
        return $"3,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}