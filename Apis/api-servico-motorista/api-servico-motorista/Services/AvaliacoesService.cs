using api_servico_motorista.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace api_servico_motorista.Services
{
    public class AvaliacoesService
    {
        private readonly IMongoCollection<Avaliacao> _avaliacoesCollection;

        public AvaliacoesService(
            IOptions<MotoristaDatabaseSettings> motoristaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                motoristaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                motoristaDatabaseSettings.Value.DatabaseName);

            _avaliacoesCollection = mongoDatabase.GetCollection<Avaliacao>(
                motoristaDatabaseSettings.Value.AvaliacoesCollectionName);
        }

        public async Task<List<Avaliacao>> GetAsync() =>
            await _avaliacoesCollection.Find(_ => true).ToListAsync();

        public async Task<Avaliacao?> GetAsync(string id) =>
            await _avaliacoesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Avaliacao newAvaliacao) =>
            await _avaliacoesCollection.InsertOneAsync(newAvaliacao);

        public async Task UpdateAsync(string id, Avaliacao updatedAvaliacao) =>
            await _avaliacoesCollection.ReplaceOneAsync(x => x.Id == id, updatedAvaliacao);

        public async Task RemoveAsync(string id) =>
            await _avaliacoesCollection.DeleteOneAsync(x => x.Id == id);
    }
}
