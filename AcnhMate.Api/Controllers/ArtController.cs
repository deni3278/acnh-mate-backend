using AcnhMate.Api.Repositories;
using AcnhMate.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcnhMate.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArtController : ControllerBase
{
    private readonly ArtRepository _artRepository;

    public ArtController(ArtRepository artRepository)
    {
        this._artRepository = artRepository;
    }

    // GET: api/Art
    [HttpGet]
    public async Task<IEnumerable<Art>> Get()
    {
        return await _artRepository.GetAllAsync();
    }

    // GET: api/Art/5
    [HttpGet("{id}")]
    public async Task<Art> Get(int id)
    {
        return await _artRepository.GetByIdAsync(id);
    }

    // POST: api/Art
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT: api/Art/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE: api/Art/5
    [HttpDelete("{id}")]
    public async Task<bool> Delete(int id)
    {
        return await _artRepository.RemoveAsync(id);
    }
}