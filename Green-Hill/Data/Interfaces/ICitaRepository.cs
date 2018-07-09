using Green_Hill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Green_Hill.Data.Interfaces
{
    public interface ICitaRepository : IRepository<Cita>
    {
        IEnumerable<Cita> GetAllCitasUsuario(int UserId);
        IEnumerable<Cita> GetCitasHoras(int UserId, int Horas);
        IEnumerable<Cita> GetCitasFecha(int UserId, DateTime Day);
    }
}
