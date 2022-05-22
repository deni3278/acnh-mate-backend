﻿using AcnhMate.Api.Repositories;
using AcnhMate.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcnhMate.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FossilsController : ControllerBase
{
    private readonly FossilsRepository _fossilsRepository;

    public FossilsController(FossilsRepository fossilsRepository)
    {
        this._fossilsRepository = fossilsRepository;
    }

    // GET: api/Fossil
    [HttpGet]
    public async Task<IEnumerable<Fossil>> Get()
    {
        return await _fossilsRepository.GetAllAsync();
    }

    // GET: api/Fossil/5
    [HttpGet("{fileName}")]
    public async Task<Fossil> Get(string fileName)
    {
        return await _fossilsRepository.GetByFileNameAsync(fileName);
    }

    // POST: api/Fossil
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT: api/Fossil/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE: api/Fossil/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}