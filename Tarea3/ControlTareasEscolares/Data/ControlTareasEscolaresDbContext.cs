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

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Tarea> Tareas { get; set; }
    }

}
