using CartorioCivilApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CartorioCivilApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Nascimento> Nascimentos { get; set; }
    }
}
