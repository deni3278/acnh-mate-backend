﻿using AcnhMate.Api.Repositories;
using AcnhMate.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcnhMate.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VillagersController : ControllerBase
{
    private readonly VillagerRepository _villagerRepository;

    public VillagersController(VillagerRepository villagerRepository)
    {
        this._villagerRepository = villagerRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Villager>> Get()
    {
        return await _villagerRepository.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<Villager> Get(int id)
    {
        return await _villagerRepository.GetByIdAsync(id);
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
        return await _villagerRepository.RemoveAsync(id);
    }
}