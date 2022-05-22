using AcnhMate.Api.Repositories;
using AcnhMate.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcnhMate.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HourlyController : ControllerBase
{
    private readonly HourlyRepository _hourlyRepository;

    public HourlyController(HourlyRepository hourlyRepository)
    {
        this._hourlyRepository = hourlyRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Hourly>> Get()
    {
        return await _hourlyRepository.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<Hourly> Get(int id)
    {
        return await _hourlyRepository.GetByIdAsync(id);
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
        return await _hourlyRepository.RemoveAsync(id);
    }
}