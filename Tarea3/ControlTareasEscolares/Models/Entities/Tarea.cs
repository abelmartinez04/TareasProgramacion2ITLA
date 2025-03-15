using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlTareasEscolares.Models.Entities
{
    [Table("Tarea")]
    public class Tarea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Titulo")]
        [MaxLength(150)]
        public string Titulo { get; set; }

        [Column("Descripcion", TypeName = "TEXT")]
        public string? Descripcion { get; set; }

        [Required]
        [Column("FechaEntrega", TypeName = "DATE")]
        public DateTime FechaEntrega { get; set; }

        [Required]
        [Column("Estado")]
        [MaxLength(50)]
        public string Estado { get; set; } = "Pendiente";

        [Column("Calificacion", TypeName = "DECIMAL(5,2)")]
        public decimal? Calificacion { get; set; }

        [ForeignKey("Estudiante")]
        public int? EstudianteId { get; set; }

        public virtual Estudiante? Estudiante { get; set; }
    }
}
