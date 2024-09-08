using System.ComponentModel.DataAnnotations;
namespace CRUDCORE.Models
{
    public class ContactoModel
    {

        public int IdContacto { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string? Telefono { get; set; }
       
        [Required(ErrorMessage = "El correo es obligatorio")]
        public string? Correo { get; set; }
        
    }
}
