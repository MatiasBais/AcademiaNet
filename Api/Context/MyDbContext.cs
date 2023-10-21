using Microsoft.EntityFrameworkCore;
using Entidades;

namespace Api.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Especialidad> Especialidades { get; set; }
    }
}
