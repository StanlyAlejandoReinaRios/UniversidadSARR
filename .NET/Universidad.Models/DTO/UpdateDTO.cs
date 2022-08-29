using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Models.DTO
{
    public class UpdateDTO
    {
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        public int Telefono { get; set; }

        //[Required]
        public int TipoUsuarioId { get; set; }
    }
}
