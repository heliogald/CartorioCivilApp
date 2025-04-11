using CartorioCivilApi.Data;
using CartorioCivilApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CartorioCivilApi.Repositories
{
    public class NascimentoRepository : INascimentoRepository
    {
        private readonly AppDbContext _context;

        public NascimentoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Nascimento> AddAsync(Nascimento nascimento)
        {
            _context.Nascimentos.Add(nascimento);
            await _context.SaveChangesAsync();
            return nascimento;
        }

        public async Task<List<Nascimento>> GetByPeriodoAsync(DateTime inicio, DateTime fim)
        {
            return await _context.Nascimentos
                .Where(n => n.DataRegistro >= inicio && n.DataRegistro <= fim)
                .ToListAsync();
        }
    }
}
