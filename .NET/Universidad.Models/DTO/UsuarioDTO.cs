using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Models.DTO
{
    public class UsuarioDTO
    {
        //[MaxLength(60), MinLength(4)]
        //[Required]
        //public string Nombre { get; set; }

        //[MaxLength(60), MinLength(4)]
        //[Required]
        //[DataType(DataType.EmailAddress)]
        //public string Correo { get; set; }

        //[MaxLength(60), MinLength(4)]
        //[Required]
        //public int Telefono { get; set; }

        //[Required]
        //public int EstadoId { get; set; }

        //[Required]
        //public int TipoUsuarioId { get; set; }


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
