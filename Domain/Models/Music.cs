namespace Domain.Models;

public class Music
{
    public Music() { }

    public Music(string name, string url, List<string> artists, bool isMusic)
    {
        Name = name;
        Url = url;
        Artist = artists;
        IsMusic = isMusic;
    }


    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Url { get; set; }
    public List<string>? Artist { get; set; }
    public bool IsMusic { get; set; }
}