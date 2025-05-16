using System.ComponentModel.DataAnnotations;

namespace Domain.Models.ViewModels.ViewModels;

public record MusicViewModel
{
    public MusicViewModel(Music music)
    {
        Name = music.Name;
        Url = music.Url;
        Artist = music.Artist;
        IsMusic = music.IsMusic;
    }

    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.", AllowEmptyStrings = false)]
    [Display(Name = "Nome")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.", AllowEmptyStrings = false)]
    [Display(Name = "cpfCnpj")]
    public string? Url { get; set; }

    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.", AllowEmptyStrings = false)]
    [Display(Name = "telefone")]
    public List<string>? Artist { get; set; }

    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.", AllowEmptyStrings = false)]
    [Display(Name = "endereco")]
    public bool IsMusic { get; set; }

    public static explicit operator Music(MusicViewModel model)
        => new(model.Name!,
               model.Url!,
               model.Artist!,
               model.IsMusic!);
}