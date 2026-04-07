public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;


    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\n" +
               $"Description: {_description}\n" +
               $"Date: {_date}\n" +
               $"Time: {_time}\n" +
               $"Address:\n{_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Date: {_date}\nTitle: {_title}";
    }
}