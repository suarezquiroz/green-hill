using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Green_Hill.Models;
using Microsoft.AspNetCore.Identity;

namespace Green_Hill.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Rol>().HasData(

                new Rol { Id = 1, Titulo = "Administrador" },
                new Rol { Id = 2, Titulo = "Paciente" },
                new Rol { Id = 3, Titulo = "Empleado" },
                new Rol { Id = 4, Titulo = "Medico" }

                );

            builder.Entity<TipoCita>().HasData(

                new TipoCita { Id = 1, Titulo = "Medicina General" },
                new TipoCita { Id = 2, Titulo = "Odontología" },
                new TipoCita { Id = 3, Titulo = "Pediatría" },
                new TipoCita { Id = 4, Titulo = "Neurología" }

                );

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Cita> Citas { get; set; }
        public DbSet<TipoCita> TiposCita { get; set; }
        public DbSet<Rol> RolesUsuario { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
