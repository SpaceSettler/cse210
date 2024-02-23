
public class Outdoor : Event
{
    private string _forecast;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _forecast = weather;
    }

    public override string FullDetails()
    {
        return $"{_eventTitle}\nThe community is hosting {_description} and you are invited! Don't forget to bring the fun!! XD {_date} {_time} {_address.FullAddress()} {_forecast}";
    }
    public override string ShortDescription()
    {
        return $"the outdoor event called {_eventTitle} on {_date}";
    }
}