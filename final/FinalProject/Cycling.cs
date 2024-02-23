
public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _date = date;
        _length = length;
        _speed = speed;
    }

    public override double Distance()
    {
        return _speed / 60 * _length;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        return _length / Distance();
    }
}
