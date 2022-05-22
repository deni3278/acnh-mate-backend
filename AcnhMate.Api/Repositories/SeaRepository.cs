using AcnhMate.Models;
using MongoDB.Driver;

namespace AcnhMate.Api.Repositories;

public class SeaRepository : BaseRepository<Sea>
{
    public SeaRepository(IMongoDatabase context) : base(context)
    {
    }
}