using AcnhMate.Api.Controllers;
using AcnhMate.Api.Repositories;
using AcnhMate.Models;
using MongoDB.Driver;
using Moq;
using Xunit;

namespace AcnhMate.Tests;

public class MusicControllerTests
{
    private readonly Music _music;
    private readonly MusicController _controller;

    public MusicControllerTests()
    {
        _music = new Music
        {
            BuyPrice = 100,
            SellPrice = 100,
            _Id = "0",
            ImageUri = "/",
            Id = 0,
            IsOrderable = true,
            MusicUri = "WhateverYouWant.mp3",
            Name = new Name
            {
                NameCNzh = "MusicMyMan",
                NameEUde = "MusicMyMan",
                NameEUen = "MusicMyMan",
                NameEUes = "MusicMyMan",
                NameEUfr = "MusicMyMan",
                NameEUit = "MusicMyMan",
                NameEUnl = "MusicMyMan",
                NameEUru = "MusicMyMan",
                NameJPja = "MusicMyMan",
                NameKRko = "MusicMyMan",
                NameTWzh = "MusicMyMan",
                NameUSen = "MusicMyMan",
                NameUSes = "MusicMyMan",
                NameUSfr = "MusicMyMan"
            },
            FileName = "Music"
        };
        var mongoContext = new Mock<IMongoDatabase>();
        var repository = new Mock<MusicRepository>(mongoContext.Object);
        repository.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(_music);
    
        _controller = new MusicController(repository.Object);
    }
    [Fact]
    public async Task GetById()
    {
        var result = await _controller.Get(1);
        Assert.Equal(_music, result);
    }
}