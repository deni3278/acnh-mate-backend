using AcnhMate.Api.Controllers;
using AcnhMate.Api.Repositories;
using AcnhMate.Models;
using MongoDB.Driver;
using Moq;
using Xunit;

namespace AcnhMate.Tests;

public class ArtControllerTests
{
    private readonly Art _art;
    private readonly ArtController _controller;

    // Set Up
    public ArtControllerTests()
    {
        _art = new Art
        {
            _Id = "0",
            BuyPrice = 100,
            FileName = "Mona Lisa",
            HasFake = true,
            Id = 0,
            ImageUri = "/",
            MuseumDesc = "HOOT HOOT",
            Name = new Name {NameEUen = "Mona Lisa"},
            SellPrice = 0
        };
        var mongoContext = new Mock<IMongoDatabase>();
        var repository = new Mock<ArtRepository>(mongoContext.Object);
        repository.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(_art);

        _controller = new ArtController(repository.Object);
    }

    [Fact]
    public async Task GetById()
    {
        var result = await _controller.Get(1);

        Assert.Equal(_art, result);
    }
}