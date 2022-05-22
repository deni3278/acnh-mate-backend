using AcnhMate.Api;
using AcnhMate.Api.Repositories;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

ConventionRegistry.Register("Camel case convention", new ConventionPack {new CamelCaseElementNameConvention()}, t => true);

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var dbSettingsSection = builder.Configuration.GetSection("AnimalCrossingDatabaseSettings");
var client = new MongoClient(dbSettingsSection.Get<AnimalCrossingDatabaseSettings>().ConnectionString);
var db = client.GetDatabase(dbSettingsSection.Get<AnimalCrossingDatabaseSettings>().DatabaseName);

builder.Services.Configure<AnimalCrossingDatabaseSettings>(dbSettingsSection);
builder.Services.AddSingleton(client);
builder.Services.AddSingleton(db);
builder.Services.AddSingleton<ArtRepository>();
builder.Services.AddSingleton<BugRepository>();
builder.Services.AddSingleton<FishRepository>();
builder.Services.AddSingleton<FossilsRepository>();
builder.Services.AddSingleton<HourlyRepository>();
builder.Services.AddSingleton<MiscRepository>();
builder.Services.AddSingleton<MusicRepository>();
builder.Services.AddSingleton<SeaRepository>();
builder.Services.AddSingleton<VillagerRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(policyBuilder =>
{
    policyBuilder.AllowAnyHeader();
    policyBuilder.AllowAnyMethod();
    policyBuilder.SetIsOriginAllowed(_ => true);
});

app.MapControllers();

app.Run();