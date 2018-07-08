using Green_Hill.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Green_Hill.Data
{
    public class GreenHillDbContext : DbContext
    {
        public GreenHillDbContext(DbContextOptions<GreenHillDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<TipoCita> TiposCita { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<ApplicationUser> Usuarios { get; set; }
    }
}
