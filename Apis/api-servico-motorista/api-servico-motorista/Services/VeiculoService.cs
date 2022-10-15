using api_servico_motorista.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace api_servico_motorista.Services
{
    public class VeiculosService
    {
        private readonly IMongoCollection<Veiculo> _veiculosCollection;

        public VeiculosService(
            IOptions<MotoristaDatabaseSettings> motoristaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                motoristaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                motoristaDatabaseSettings.Value.DatabaseName);

            _veiculosCollection = mongoDatabase.GetCollection<Veiculo>(
                motoristaDatabaseSettings.Value.VeiculosCollectionName);
        }

        public async Task<List<Veiculo>> GetAsync() =>
            await _veiculosCollection.Find(_ => true).ToListAsync();

        public async Task<Veiculo?> GetAsync(string id) =>
            await _veiculosCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Veiculo newVeiculo) =>
            await _veiculosCollection.InsertOneAsync(newVeiculo);

        public async Task UpdateAsync(string id, Veiculo updatedVeiculo) =>
            await _veiculosCollection.ReplaceOneAsync(x => x.Id == id, updatedVeiculo);

        public async Task RemoveAsync(string id) =>
            await _veiculosCollection.DeleteOneAsync(x => x.Id == id);
    }
}
