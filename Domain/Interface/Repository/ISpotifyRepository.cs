using Domain.Models;

namespace Domain.Interface.Repository;

public interface ISpotifyRepository
{
    Task<Insight?> GetInsights();
    Task<IEnumerable<Music?>?> GetMusics();
    Task<IEnumerable<Album?>?> GetAlbums();
    Task<IEnumerable<Artist?>?> GetArtists();
}