using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace api_servico_motorista.Models
{
    public class Viagem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Origem { get; set; }
        public string Destino { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInicioSolicitacao { get; set; }
        public DateTime? DataFimSolicitacao { get; set; }
       // public Motorista Motorista { get; set; }
       // public Veiculo Veiculo { get; set; }

    }
}
