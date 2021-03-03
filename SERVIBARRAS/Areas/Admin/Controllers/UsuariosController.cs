
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using SERVIBARRAS.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SERVIBARRAS.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class UsuariosController : Controller
    {

        private readonly IContenedorTrabajo _contenedorTrabajo;

        public UsuariosController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }


        public IActionResult Index()
        {
            // Asi se llama en la base de datos, lo que vamos a hacer es que el usuario autenticado lo guardamos aqui
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            // Aqui validamos el id del usuario actual
            var usuarioActual = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            // Cargamos la lista con todos los usuarios esepto el usuario actual o el mio.
            return View(_contenedorTrabajo.Usuario.GetAll(u => u.Id != usuarioActual.Value));
        }


        public IActionResult Bloquear(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _contenedorTrabajo.Usuario.BloqueaUsuario(id);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Desbloquear(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _contenedorTrabajo.Usuario.DesbloquearUsuario(id);
            return RedirectToAction(nameof(Index));
        }

    }
}