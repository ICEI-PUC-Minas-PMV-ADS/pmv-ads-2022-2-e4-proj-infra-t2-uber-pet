using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace api_servico_motorista.Models
{
    public class Veiculo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public string DocumentoVeiculo { get; set; }
       // public Motorista Motorista { get; set; }
    }
}
