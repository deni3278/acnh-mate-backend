using AcnhMate.Models;
using MongoDB.Driver;

namespace AcnhMate.Api.Repositories;

public class FossilsRepository : BaseRepository<Fossil>
{
    public FossilsRepository(IMongoDatabase context) : base(context)
    {
    }

    public override Task<Fossil> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}