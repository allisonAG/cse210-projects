public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} {_promptText} {_entryText}");
        Console.WriteLine();
    }

    public string GetEntryAsString()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }
}