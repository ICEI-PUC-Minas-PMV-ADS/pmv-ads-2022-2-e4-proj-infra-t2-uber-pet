using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace api_servico_motorista.Models
{
    public class Avaliacao
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public int Nota { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataAvalicao { get; set; }
       // public Motorista Motorista { get; set; }
    }
}
