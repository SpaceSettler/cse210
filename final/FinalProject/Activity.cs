
public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_length} min)- Distance {Math.Round(Distance(), 2)} miles, Speed {Math.Round(Speed(), 2)} mph, Pace: {Math.Round(Pace(), 2)} min per mile";
    }
}