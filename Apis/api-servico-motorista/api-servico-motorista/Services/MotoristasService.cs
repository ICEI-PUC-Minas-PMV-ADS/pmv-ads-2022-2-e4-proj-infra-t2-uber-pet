using api_servico_motorista.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace api_servico_motorista.Services
{
    public class MotoristasService
    {
        private readonly IMongoCollection<Motorista> _motoristasCollection;

        public MotoristasService(
            IOptions<MotoristaDatabaseSettings> motoristaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                motoristaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                motoristaDatabaseSettings.Value.DatabaseName);

            _motoristasCollection = mongoDatabase.GetCollection<Motorista>(
                motoristaDatabaseSettings.Value.MotoristaCollectionName);
        }

        public async Task<List<Motorista>> GetAsync() =>
            await _motoristasCollection.Find(_ => true).ToListAsync();

        public async Task<Motorista?> GetAsync(string id) =>
            await _motoristasCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Motorista newMotorista) =>
            await _motoristasCollection.InsertOneAsync(newMotorista);

        public async Task UpdateAsync(string id, Motorista updatedMotorista) =>
            await _motoristasCollection.ReplaceOneAsync(x => x.Id == id, updatedMotorista);

        public async Task RemoveAsync(string id) =>
            await _motoristasCollection.DeleteOneAsync(x => x.Id == id);
    }
}
