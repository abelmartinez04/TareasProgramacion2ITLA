using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;

namespace ControlTareasEscolares.Models.Entities
{
    public class Estudiente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Nombre")]
        [MaxLength(100)]

        public string Nombre { get; set; }

        [Required, EmailAddress]
        [Column("Correo")]
        [MaxLength(100)]
        public string Correo { get; set; }
        [Column("FechaRegistro")]
        public DateTime ? FechaRegistro { get; set; } = DateTime.Now;

        //public ICollection<Tarea> Tareas { get; set; }
    }
}

