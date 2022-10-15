using api_servico_motorista.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace api_servico_motorista.Services
{
    public class ViagensService
    {
        private readonly IMongoCollection<Viagem> _viagensCollection;

        public ViagensService(
            IOptions<MotoristaDatabaseSettings> motoristaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                motoristaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                motoristaDatabaseSettings.Value.DatabaseName);

            _viagensCollection = mongoDatabase.GetCollection<Viagem>(
                motoristaDatabaseSettings.Value.ViagensCollectionName);
        }

        public async Task<List<Viagem>> GetAsync() =>
            await _viagensCollection.Find(_ => true).ToListAsync();

        public async Task<Viagem?> GetAsync(string id) =>
            await _viagensCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Viagem newViagem) =>
            await _viagensCollection.InsertOneAsync(newViagem);

        public async Task UpdateAsync(string id, Viagem updatedViagem) =>
            await _viagensCollection.ReplaceOneAsync(x => x.Id == id, updatedViagem);

        public async Task RemoveAsync(string id) =>
            await _viagensCollection.DeleteOneAsync(x => x.Id == id);
    }
}
