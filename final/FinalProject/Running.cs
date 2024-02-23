
public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _date = date;
        _length = length;
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }
    public override double Pace()
    {
        return _length / _distance;
    }
}