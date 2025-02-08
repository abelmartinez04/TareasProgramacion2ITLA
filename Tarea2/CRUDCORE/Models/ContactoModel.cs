using System.ComponentModel.DataAnnotations;

namespace CRUDCORE.Models
{
    public class ContactoModel
    {

        public int IdContact { get; set; }

        [Required(ErrorMessage ="El campo Nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        public string? Correo { get; set; }
    }
}
// me quede aqui https://youtu.be/qcRCDM5KiSo?si=d1jaeq7ct_F-xC7q&t=4583