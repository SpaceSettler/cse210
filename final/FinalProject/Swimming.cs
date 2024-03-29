
public class Swimming : Activity
{
    private int _numLaps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _date = date;
        _length = length;
        _numLaps = laps;
    }

    public override double Distance()
    {
        return _numLaps * 50 / 1000 * 0.62;
    }

}