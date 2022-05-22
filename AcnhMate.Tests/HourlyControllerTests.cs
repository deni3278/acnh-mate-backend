using AcnhMate.Api.Controllers;
using AcnhMate.Api.Repositories;
using AcnhMate.Models;
using MongoDB.Driver;
using Moq;
using Xunit;

namespace AcnhMate.Tests;

public class HourlyControllerTests
{
    private readonly Hourly _hourly;
    private readonly HourlyController _controller;
    public HourlyControllerTests()
    {
        _hourly = new Hourly
        {
            Hour = 16,
            MusicUri = "NeverGonnaGiveYouUp.mp3",
            Weather = "Disco"
        };
        var mongoContext = new Mock<IMongoDatabase>();
        var repository = new Mock<HourlyRepository>(mongoContext.Object);
        repository.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(_hourly);

        _controller = new HourlyController(repository.Object);
    }

    [Fact]
    public async Task GetById()
    {
        var result = await _controller.Get(1);
        Assert.Equal(_hourly, result);
    }
    
}