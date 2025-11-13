using MongoDB.Driver;
using PerifaFlow.Application.Configs;

namespace PerifaFlow.Infrastructure.Contexts.MongoDB;

public class MongoContext
{
    private readonly IMongoDatabase _database;

    public MongoContext(Settings settings)
    {
        var client = new MongoClient(settings.MongoDb.ConnectionString);
        _database = client.GetDatabase(settings.MongoDb.DatabaseName);
    }
    
    public IMongoDatabase Database => _database;
}