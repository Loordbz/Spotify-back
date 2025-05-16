using Domain.Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/spotify")]
public class SpotifyController : ControllerBase
{
    private readonly ISpotifyService _service;
    public SpotifyController(ISpotifyService service)
        => _service = service;

    [HttpGet]
    [Route("insights")]
    public async Task<IActionResult> GetInsights()
        => Ok(await _service.GetInsights());

    [HttpGet]
    [Route($"musics")]
    public async Task<IActionResult> GetMusics()
        => Ok(await _service.GetMusics());

    [HttpGet]
    [Route($"albums")]
    public async Task<IActionResult> GetAlbums()
        => Ok(await _service.GetAlbums());

    [HttpGet]
    [Route("artists")]
    public async Task<IActionResult> GetArtists()
        => Ok(await _service.GetArtists());

}