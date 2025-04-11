using CartorioCivilApi.Models;

namespace CartorioCivilApi.Repositories
{
    public interface INascimentoRepository
    {
        Task<Nascimento> AddAsync(Nascimento nascimento);
        Task<List<Nascimento>> GetByPeriodoAsync(DateTime inicio, DateTime fim);
    }
}
