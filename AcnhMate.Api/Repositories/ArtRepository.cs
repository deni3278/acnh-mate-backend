using AcnhMate.Models;
using MongoDB.Driver;

namespace AcnhMate.Api.Repositories;

public class ArtRepository : BaseRepository<Art>
{
    public ArtRepository(IMongoDatabase context) : base(context)
    {
    }
}