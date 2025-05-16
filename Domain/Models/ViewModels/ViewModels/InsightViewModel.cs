using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public record InsightViewModel
{
    public InsightViewModel(Insight insight)
    {
        MinuteChart = new MinuteChartViewModel(insight.MinuteChart);
        StyleChart = new StyleChartViewModel(insight.StyleChart);
        MusicChart = new MusicChartViewModel(insight.MusicChart);
        NewStyleChart = new NewStyleChartViewModel(insight.NewStyleChart);
    }

    [Display(Name = "minuteChart")]
    public MinuteChartViewModel MinuteChart { get; set; }

    [Display(Name = "styleChart")]
    public StyleChartViewModel StyleChart { get; set; }

    [Display(Name = "musicChart")]
    public MusicChartViewModel MusicChart { get; set; }

    [Display(Name = "newStyleChart")]
    public NewStyleChartViewModel NewStyleChart { get; set; }
}

public record StyleChartViewModel
{
    public StyleChartViewModel(StyleChart styleChart)
    {
        Style = styleChart.Style;
        Results = styleChart.Results;
        BackgroundColor = styleChart.BackgroundColor;
    }

    [Display(Name = "style")]
    public List<string> Style { get; set; }

    [Display(Name = "results")]
    public List<int> Results { get; set; }

    [Display(Name = "backgroundColor")]
    public List<string> BackgroundColor { get; set; }

    public static explicit operator StyleChart(StyleChartViewModel model)
       => new(model.Style,
              model.Results!,
              model.BackgroundColor!);
}

public record MinuteChartViewModel
{
    public MinuteChartViewModel(MinuteChart minuteChart)
    {
        Month = minuteChart.Month;
        Results = minuteChart.Results;
        BackgroundColor = minuteChart.BackgroundColor;
        BorderColor = minuteChart.BorderColor;
    }

    [Display(Name = "month")]
    public List<string> Month { get; set; }

    [Display(Name = "results")]
    public List<int> Results { get; set; }

    [Display(Name = "backgroundColor")]
    public List<string> BackgroundColor { get; set; }

    [Display(Name = "borderColor")]
    public List<string> BorderColor { get; set; }

    public static explicit operator MinuteChart(MinuteChartViewModel model)
       => new(model.Month,
              model.Results!,
              model.BackgroundColor!,
              model.BorderColor!);
}

public record MusicChartViewModel
{
    public MusicChartViewModel(MusicChart minuteChart)
    {
        Music = minuteChart.Music;
        Results = minuteChart.Results;
        BackgroundColor = minuteChart.BackgroundColor;
        BorderColor = minuteChart.BorderColor;
    }

    [Display(Name = "musics")]
    public List<string> Music { get; set; }

    [Display(Name = "results")]
    public List<int> Results { get; set; }

    [Display(Name = "backgroundColor")]
    public List<string> BackgroundColor { get; set; }

    [Display(Name = "borderColor")]
    public List<string> BorderColor { get; set; }

    public static explicit operator MusicChart(MusicChartViewModel model)
       => new(model.Music,
              model.Results!,
              model.BackgroundColor!,
              model.BorderColor!);
}

public record NewStyleChartViewModel
{
    public NewStyleChartViewModel(NewStyleChart styleChart)
    {
        Style = styleChart.Style;
        Results = styleChart.Results;
        BackgroundColor = styleChart.BackgroundColor;
    }

    [Display(Name = "style")]
    public List<string> Style { get; set; }

    [Display(Name = "results")]
    public List<int> Results { get; set; }

    [Display(Name = "backgroundColor")]
    public List<string> BackgroundColor { get; set; }

    public static explicit operator NewStyleChart(NewStyleChartViewModel model)
       => new(model.Style,
              model.Results!,
              model.BackgroundColor!);
}