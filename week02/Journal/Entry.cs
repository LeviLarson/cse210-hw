using System;

public class Entry
{
    public string _prompt { get; set; }
    public string _response { get; set; }
    public string _date { get; set; }

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("MM/dd/yyyy");
    }

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}\n");
    }

    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    public static Entry FromFileString(string line)
    {
        var parts = line.Split('|');
        return new Entry(parts[1], parts[2], parts[0]);
    }
}
