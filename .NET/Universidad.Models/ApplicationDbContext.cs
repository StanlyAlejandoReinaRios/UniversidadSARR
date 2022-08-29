using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Models.Entities;

namespace Universidad.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<TipoUsuario> TipoUsuarios { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
