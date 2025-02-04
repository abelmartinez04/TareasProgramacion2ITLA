using System.ComponentModel.DataAnnotations;

namespace CRUDCORE.Models
{
    public class ContactoModel
    {

        public int IdContact { get; set; }

        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Telefono { get; set; }
        [Required]
        public string? Correo { get; set; }
    }
}
// me quede aqui https://youtu.be/qcRCDM5KiSo?si=jh6tlTGTt3mNkyJw