using CartorioCivilApi.DTOs;
using CartorioCivilApi.Models;
using CartorioCivilApi.Repositories;

namespace CartorioCivilApi.Services
{
    public class NascimentoService
    {
        private readonly INascimentoRepository _repository;

        public NascimentoService(INascimentoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Nascimento> CriarAsync(NascimentoDTO dto)
        {
            var nascimento = new Nascimento
            {
                DataRegistro = dto.DataRegistro,
                DataNascimento = dto.DataNascimento,
                NomeRegistrado = dto.NomeRegistrado,
                NomePai = dto.NomePai,
                NomeMae = dto.NomeMae,
                DataNascimentoPai = dto.DataNascimentoPai,
                DataNascimentoMae = dto.DataNascimentoMae,
                CpfPai = dto.CpfPai,
                CpfMae = dto.CpfMae
            };

            return await _repository.AddAsync(nascimento);
        }

        public async Task<List<Nascimento>> GetRelatorio(DateTime inicio, DateTime fim)
        {
            return await _repository.GetByPeriodoAsync(inicio, fim);
        }
    }
}
