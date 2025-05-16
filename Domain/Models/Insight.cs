namespace Domain.Models;

public class Insight
{
    public Insight() { }

    public Insight(MinuteChart minuteChart, StyleChart styleChart, MusicChart musicChart, NewStyleChart newStyleChart)
    {
        MinuteChart = minuteChart;
        StyleChart = styleChart;
        MusicChart = musicChart;
        NewStyleChart = newStyleChart;
    }

    public MinuteChart MinuteChart { get; set; }
    public StyleChart StyleChart { get; set; }
    public MusicChart MusicChart { get; set; }
    public NewStyleChart NewStyleChart { get; set; }
}

public class StyleChart
{
    public StyleChart() { }

    public StyleChart(List<string> style, List<int> results, List<string> backgroundColor)
    {
        Style = style;
        Results = results;
        BackgroundColor = backgroundColor;
    }

    public List<string> Style { get; set; }
    public List<int> Results { get; set; }
    public List<string> BackgroundColor { get; set; }
}

public class MinuteChart
{
    public MinuteChart() { }

    public MinuteChart(List<string> month, List<int> results, List<string> backgroundColor, List<string> borderColor)
    {
        Month = month;
        Results = results;
        BackgroundColor = backgroundColor;
        BorderColor = borderColor;
    }

    public List<string> Month { get; set; }
    public List<int> Results { get; set; }
    public List<string> BackgroundColor { get; set; }
    public List<string> BorderColor { get; set; }
}

public class MusicChart
{
    public MusicChart() { }

    public MusicChart(List<string> music, List<int> results, List<string> backgroundColor, List<string> borderColor)
    {
        Music = music;
        Results = results;
        BackgroundColor = backgroundColor;
        BorderColor = borderColor;
    }

    public List<string> Music { get; set; }
    public List<int> Results { get; set; }
    public List<string> BackgroundColor { get; set; }
    public List<string> BorderColor { get; set; }
}

public class NewStyleChart
{
    public NewStyleChart() { }

    public NewStyleChart(List<string> style, List<int> results, List<string> backgroundColor)
    {
        Style = style;
        Results = results;
        BackgroundColor = backgroundColor;
    }

    public List<string> Style { get; set; }
    public List<int> Results { get; set; }
    public List<string> BackgroundColor { get; set; }
}