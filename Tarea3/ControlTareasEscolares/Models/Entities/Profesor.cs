using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlTareasEscolares.Models.Entities
{
    [Table("Profesor")]
    public class Profesor
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

        [Column("Especialidad")]
        public string ? Especialidad { get; set; }
    }
}
