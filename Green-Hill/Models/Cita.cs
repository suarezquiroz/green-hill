using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Green_Hill.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("TipoCita")]
        public int TipoCitaId { get; set; }
        public TipoCita TipoCita { get; set; }

    }
}
