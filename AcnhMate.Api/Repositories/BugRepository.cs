using AcnhMate.Models;
using MongoDB.Driver;

namespace AcnhMate.Api.Repositories;

public class BugRepository : BaseRepository<Bug>
{
    public BugRepository(IMongoDatabase context) : base(context)
    {
    }
}