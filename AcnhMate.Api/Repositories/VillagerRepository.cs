using AcnhMate.Models;
using MongoDB.Driver;

namespace AcnhMate.Api.Repositories;

public class VillagerRepository : BaseRepository<Villager>
{
    public VillagerRepository(IMongoDatabase context) : base(context)
    {
    }
}