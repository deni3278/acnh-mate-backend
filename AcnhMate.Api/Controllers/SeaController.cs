using AcnhMate.Api.Repositories;
using AcnhMate.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcnhMate.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SeaController : ControllerBase
{
    private readonly SeaRepository _seaRepository;

    public SeaController(SeaRepository seaRepository)
    {
        this._seaRepository = seaRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Sea>> Get()
    {
        return await _seaRepository.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<Sea> Get(int id)
    {
        return await _seaRepository.GetByIdAsync(id);
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
        return await _seaRepository.RemoveAsync(id);
    }
}