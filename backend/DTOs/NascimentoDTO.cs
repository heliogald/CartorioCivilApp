namespace CartorioCivilApi.DTOs
{
    public class NascimentoDTO
    {
        public DateTime DataRegistro { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeRegistrado { get; set; }

        public string NomePai { get; set; }
        public string NomeMae { get; set; }

        public DateTime DataNascimentoPai { get; set; }
        public DateTime DataNascimentoMae { get; set; }

        public string CpfPai { get; set; }
        public string CpfMae { get; set; }
    }
}
