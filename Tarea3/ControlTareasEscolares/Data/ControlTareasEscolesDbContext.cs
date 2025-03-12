using ControlTareasEscolares.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControlTareasEscolares.Data
{
    public class ControlTareasEscolaresContext : DbContext
    {
        public ControlTareasEscolaresContext(DbContextOptions<ControlTareasEscolaresContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiente> Estudiantes { get; set; }
    }

}
