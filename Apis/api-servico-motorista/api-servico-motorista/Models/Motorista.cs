using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace api_servico_motorista.Models
{
    public class Motorista
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string NomeMotorista { get; set; }

        public string CNH { get; set; }
        public string Telefone { get; set; }
        public string RG { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime VencimentoCNH { get; set; }
        public Veiculo? Veiculo { get; set; }
        public Viagem? Viagem { get; set; }
        public Avaliacao? Avaliacao { get; set; }

    }
}
