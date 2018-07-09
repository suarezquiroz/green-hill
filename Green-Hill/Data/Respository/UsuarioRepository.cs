using Green_Hill.Data.Interfaces;
using Green_Hill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Green_Hill.Data.Respository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Usuario GetByIdentityUserId(string identityUserId)
        {
            return _context.Usuarios.SingleOrDefault(u => u.IdentityUserId == identityUserId);
        }

    }
}
