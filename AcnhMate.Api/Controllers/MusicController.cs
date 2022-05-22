using AcnhMate.Api.Repositories;
using AcnhMate.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcnhMate.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MusicController : ControllerBase
{
    private readonly MusicRepository _musicRepository;

    public MusicController(MusicRepository musicRepository)
    {
        this._musicRepository = musicRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Music>> Get()
    {
        return await _musicRepository.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<Music> Get(int id)
    {
        return await _musicRepository.GetByIdAsync(id);
    }

    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    [HttpDelete("{id}")]
    public async Task<bool> Delete(int id)
    {
        return await _musicRepository.RemoveAsync(id);
    }
}