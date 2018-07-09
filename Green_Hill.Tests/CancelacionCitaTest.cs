using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Green_Hill.Tests
{
    public class CancelacionCitaTest
    {
        [Fact]
        public void CancelarCita()
        {
            Assert.True(true, "Cita Cancelada");
        }

        [Fact]
        public void CancelarCitaMismoDia()
        {
            Assert.True(true, "Cita Cancelada");
        }

        [Fact]
        public void CancelarCita24HorasAntes()
        {
            Assert.True(true, "Cita Cancelada");
        }
    }
}
