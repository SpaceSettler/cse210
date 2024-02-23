
public abstract class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        return $"{_eventTitle}\n{_description}\nWhen: {_date} {_time}\nWhere: {_address.FullAddress()}";
    }
    public abstract string FullDetails();
    public abstract string ShortDescription();
}