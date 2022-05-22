using AcnhMate.Models;
using MongoDB.Driver;

namespace AcnhMate.Api.Repositories;

public class HourlyRepository : BaseRepository<Hourly>
{
    public HourlyRepository(IMongoDatabase context) : base(context)
    {
    }
}