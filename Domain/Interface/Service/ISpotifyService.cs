using Domain.Models;
using Domain.Models.ViewModels.ViewModels;

namespace Domain.Interface.Service;

public interface ISpotifyService
{
    Task<InsightViewModel?> GetInsights();
    Task<IEnumerable<MusicViewModel?>?> GetMusics();
    Task<IEnumerable<AlbumViewModel?>?> GetAlbums();
    Task<IEnumerable<ArtistViewModel?>?> GetArtists();
}