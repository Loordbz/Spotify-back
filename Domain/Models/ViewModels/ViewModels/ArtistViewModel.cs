using System.ComponentModel.DataAnnotations;

namespace Domain.Models.ViewModels.ViewModels;

public record ArtistViewModel
{
    public ArtistViewModel(Artist artist)
    {
        Name = artist.Name;
        Url = artist.Url;
    }


    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.", AllowEmptyStrings = false)]
    [Display(Name = "Name")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.", AllowEmptyStrings = false)]
    [Display(Name = "url")]
    public string? Url { get; set; }

    public static explicit operator Artist(ArtistViewModel model)
        => new(model.Name!, model.Url!);
}