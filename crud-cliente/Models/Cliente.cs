using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace crud_cliente.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Tipo de Documento es Obligatorio.")]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "El Documento es Obligatorio.")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "El Celular es Obligatorio.")]
        public string Celular {  get; set; }

        [Required(ErrorMessage = "La Direccion es Obligatoria.")]
        public string Direccion {  get; set; }
    }
}
