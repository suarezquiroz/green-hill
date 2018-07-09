using Green_Hill.Data.Interfaces;
using Green_Hill.Models;
using Green_Hill.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Green_Hill.Controllers
{
    public class CitaController : Controller
    {
        private readonly ICitaRepository _citas;
        private readonly IUsuarioRepository _usuarios;
        private readonly ITipoCitaRepository _tiposCita;
        private readonly UserManager<IdentityUser> _userManager;

        public CitaController(
            ICitaRepository citas,
            IUsuarioRepository usuarios,
            ITipoCitaRepository tiposCita,
            UserManager<IdentityUser> userManager
            )
        {
            _citas = citas;
            _usuarios = usuarios;
            _userManager = userManager;
            _tiposCita = tiposCita;

        }

        public IActionResult Listado()
        {
            var citas = _citas.GetAllCitasUsuario(_usuarios.GetByIdentityUserId(_userManager.GetUserId(this.User)).Id);
            return View(citas);
        }

        public IActionResult Create()
        {
            CitaViewModel citaVM = new CitaViewModel()
            {
                TiposCita = _tiposCita.GetAll(),
                Fecha = DateTime.Now.AddDays(1),
                Hora = DateTime.Now
            };
            return View(citaVM);
        }

        [HttpPost]
        public IActionResult Create(CitaViewModel vm)
        {
            vm.Cita.Usuario = _usuarios.GetByIdentityUserId(_userManager.GetUserId(this.User));
            vm.Cita.Fecha = new DateTime(vm.Fecha.Year, vm.Fecha.Month, vm.Fecha.Day, vm.Hora.Hour, vm.Hora.Minute, 0);
            _citas.Create(vm.Cita);
            return RedirectToAction("Listado");
        }
    }
}
