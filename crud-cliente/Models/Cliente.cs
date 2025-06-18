using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace crud_cliente.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string TipoDocumento { get; set; }

        public string Documento { get; set; }

        public string Celular {  get; set; }

        public string Direccion {  get; set; }
    }
}
