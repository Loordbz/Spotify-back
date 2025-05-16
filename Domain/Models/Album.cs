namespace Domain.Models;

public class Album
{
    public Album() { }

    public Album(string name, string url, string artist)
    {
        Name = name;
        Url = url;
        Artist = artist;
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Url { get; set; }
    public string? Artist { get; set; }
}