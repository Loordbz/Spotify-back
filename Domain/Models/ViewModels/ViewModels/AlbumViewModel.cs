using System.ComponentModel.DataAnnotations;

namespace Domain.Models.ViewModels.ViewModels;

public record AlbumViewModel
{
    public AlbumViewModel(Album album)
    {
        Name = album.Name;
        Url = album.Url;
        Artist = album.Artist;
    }


    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.", AllowEmptyStrings = false)]
    [Display(Name = "Name")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.", AllowEmptyStrings = false)]
    [Display(Name = "url")]
    public string? Url { get; set; }

    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.", AllowEmptyStrings = false)]
    [Display(Name = "artist")]
    public string? Artist { get; set; }

    public static explicit operator Album(AlbumViewModel model)
        => new(model.Name!,
               model.Url!,
               model.Artist!);
}