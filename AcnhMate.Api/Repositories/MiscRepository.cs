using AcnhMate.Models;
using MongoDB.Driver;

namespace AcnhMate.Api.Repositories;

public class MiscRepository : BaseRepository<Misc>
{
    public MiscRepository(IMongoDatabase context) : base(context)
    {
    }
}