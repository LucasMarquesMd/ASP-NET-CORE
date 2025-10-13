using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FutebolApi
{
    public class AppDbContext : DbContext
    {
        // Configura o banco de dados
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Time> Times => Set<Time>();// Tranasforma a classe Time em uma tabela
    }
}