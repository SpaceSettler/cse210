
public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base (title, description, date, time, address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _email = email;
    }

    public override string FullDetails()
    {
        return $"{_eventTitle}\nCome along and celebrate the {_description} {_date} {_time} {_address.FullAddress()}\n{Register()}";
    }
    public override string ShortDescription()
    {
        return $"{_eventTitle} on {_date}";
    }
    public string Register()
    {
        return $"Make sure to send an RSVP to {_email} if you plan on coming.";
    }
}