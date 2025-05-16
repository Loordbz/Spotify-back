using Domain.Exceptions;
using Domain.Interface.Repository;
using Domain.Interface.Service;
using Domain.Models;
using Domain.Models.ViewModels.ViewModels;
using System.Net;

namespace Service.Services;

public class SpotifyService : ISpotifyService
{
    private readonly ISpotifyRepository _repository;

    public SpotifyService(ISpotifyRepository repository)
        => _repository = repository;

    public async Task<InsightViewModel?> GetInsights()
    {
        var result = await _repository.GetInsights();
        return result is null ? throw CustomException.ThrowNewException(HttpStatusCode.NotFound, "Cliente não localizado.") :
                  new InsightViewModel(result!);
    }

    public async Task<IEnumerable<MusicViewModel?>?> GetMusics()
    {
        var result = await _repository.GetMusics();
        return result is null ? throw CustomException.ThrowNewException(HttpStatusCode.NotFound, "Musica não localizada.") :
                  result.Select(item => new MusicViewModel(item!));
    }

    public async Task<IEnumerable<AlbumViewModel?>?> GetAlbums()
    {
        var result = await _repository.GetAlbums();
        return result is null ? throw CustomException.ThrowNewException(HttpStatusCode.NotFound, "Cliente não localizado.") :
                  result.Select(item => new AlbumViewModel(item!));
    }

    public async Task<IEnumerable<ArtistViewModel?>?> GetArtists()
    {
        var result = await _repository.GetArtists();
        return result is null ? throw CustomException.ThrowNewException(HttpStatusCode.NotFound, "Artista não localizado(a).") :
                  result.Select(item => new ArtistViewModel(item!));
    }
}