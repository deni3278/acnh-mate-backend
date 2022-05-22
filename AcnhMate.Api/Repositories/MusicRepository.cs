using AcnhMate.Models;
using MongoDB.Driver;

namespace AcnhMate.Api.Repositories;

public class MusicRepository : BaseRepository<Music>
{
    public MusicRepository(IMongoDatabase context) : base(context)
    {
    }
}