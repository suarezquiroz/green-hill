using Green_Hill.Data.Interfaces;
using Green_Hill.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Green_Hill.Data.Respository
{
    public class CitaRepository : Repository<Cita>, ICitaRepository
    {
        public CitaRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Cita> GetAllCitasUsuario(int UserId)
        {
            return _context.Citas.Where(c => c.UsuarioId == UserId).ToList();
        }

        public IEnumerable<Cita> GetCitasFecha(int UserId, DateTime Day)
        {
            return _context.Citas.Where(c => c.UsuarioId == UserId && c.Fecha.Date == Day.Date);
        }

        public IEnumerable<Cita> GetCitasHoras(int UserId, int Horas)
        {
            return _context.Citas.Where(c => c.UsuarioId == UserId && (c.Fecha - DateTime.Now).Hours < Horas );
        }
    }
}
