using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Models.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Correo { get; set; }

        public int Telefono { get; set; }

        public int TipoUsuarioId { get; set; }

        public virtual TipoUsuario TipoUsuarios { get; set; }



    }
}
