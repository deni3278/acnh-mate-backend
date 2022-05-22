using AcnhMate.Models;
using MongoDB.Driver;

namespace AcnhMate.Api.Repositories;

public class FishRepository : BaseRepository<Fish>
{
    public FishRepository(IMongoDatabase context) : base(context)
    {
    }
}