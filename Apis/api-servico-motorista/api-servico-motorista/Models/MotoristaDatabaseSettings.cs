namespace api_servico_motorista.Models
{
    public class MotoristaDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string MotoristaCollectionName { get; set; } = null!;
        public string VeiculosCollectionName { get; set; } = null!;
        public string ViagensCollectionName { get; set; } = null!;
        public string AvaliacoesCollectionName { get; set; } = null!;
    }
}
