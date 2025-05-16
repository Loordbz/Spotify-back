namespace Domain.Models;

public class Artist
{
    public Artist() { }

    public Artist(string name, string url)
    {
        Name = name;
        Url = url;
    }

    public string? Name { get; set; }
    public string? Url { get; set; }
}