public class Entry
{
    public string _date;
    public string _prompText;
    public string _entryText;



    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompText}");
        Console.WriteLine($"{_entryText}");
    }
}