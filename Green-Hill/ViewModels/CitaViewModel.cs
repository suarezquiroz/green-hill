using Green_Hill.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Green_Hill.ViewModels
{
    public class CitaViewModel
    {
        public Cita Cita { get; set; }
        public IEnumerable<TipoCita> TiposCita { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH mm}")]
        public DateTime Hora { get; set; }
    }
}
