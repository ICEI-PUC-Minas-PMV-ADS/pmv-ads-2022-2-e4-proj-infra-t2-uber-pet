using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace api_servico_motorista.Models
{
    public class Motorista
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string NomeMotorista { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Senha { get; set; } = null!;

        public string CNH { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public string RG { get; set; } = null!;
        public DateTime DataCadastro { get; set; }
        public DateTime VencimentoCNH { get; set; }
        public Veiculo? Veiculo { get; set; }
        public Viagem? Viagem { get; set; }
        public Avaliacao? Avaliacao { get; set; }

    }
}
