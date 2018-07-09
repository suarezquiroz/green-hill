using Green_Hill.Data.Interfaces;
using Green_Hill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Green_Hill.Data.Respository
{
    public class TipoCitaRepository : Repository<TipoCita>, ITipoCitaRepository
    {
        public TipoCitaRepository(ApplicationDbContext context) : base(context)
    {
    }

}
}
