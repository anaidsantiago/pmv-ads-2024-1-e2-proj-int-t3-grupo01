using GestLab.Models;
using Microsoft.EntityFrameworkCore;

namespace GestLab.Data
{
    public class GestLabContext:DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=GestLab;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
