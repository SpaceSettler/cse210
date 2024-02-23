
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{_eventTitle}\nJoin us, as we look upon{_description} On {_date} at {_time} there will be an amazing lecture by the one and only {_speaker} at {_address.FullAddress()}! Don't wait too long, there are only {_capacity} seats. You won't want to miss this!";
    }
    public override string ShortDescription()
    {
        return $"a lecture titled {_eventTitle} on {_date}";
    }
}