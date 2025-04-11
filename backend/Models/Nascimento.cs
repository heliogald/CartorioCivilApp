namespace CartorioCivilApi.Models
{
    public class Nascimento
    {
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeRegistrado { get; set; } = string.Empty;

        public string NomePai { get; set; } = string.Empty;
        public string NomeMae { get; set; } = string.Empty;

        public DateTime DataNascimentoPai { get; set; }
        public DateTime DataNascimentoMae { get; set; }

        public string CpfPai { get; set; } = string.Empty;
        public string CpfMae { get; set; } = string.Empty;
    }
}
