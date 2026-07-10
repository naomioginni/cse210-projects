using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }

    public string ToFileString()
    {
        return $"{Date}~|~{Prompt}~|~{Response}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("~|~");
        string date = parts[0];
        string prompt = parts[1];
        string response = parts[2];
        return new Entry(date, prompt, response);
    }
}