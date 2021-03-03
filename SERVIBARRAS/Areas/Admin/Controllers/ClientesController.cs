// Tabla Dependiente => Clientes
using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using SERVIBARRAS.Models.ViewModels;
using SERVIBARRAS.AccesoDatos.Data.Repository;

namespace SERVIBARRAS.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class ClientesController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ClientesController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ClientesVM clientesvm = new ClientesVM()
            {
                Clientes = new Models.Clientes(),
                ListaCiudad = _contenedorTrabajo.Ciudad.GetListaCiudad(),
                ListaVendedor = _contenedorTrabajo.Vendedor.GetListaVendedor(),
                ListaTipoGranContribuyente = _contenedorTrabajo.TipoGranContribuyente.GetListaTipoGranContribuyente(),

            };
            return View(clientesvm);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClientesVM clientesvm)
        {
            if (ModelState.IsValid)
            {
                string rutaPrincipal = _hostingEnvironment.WebRootPath;
                var archivos = HttpContext.Request.Form.Files;

                if (clientesvm.Clientes.ClienteId == 0)
                {
 
 
                    _contenedorTrabajo.Clientes.Add(clientesvm.Clientes);
                    _contenedorTrabajo.Save();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View();
        }

        private static void CrearImagenClientes(ClientesVM clientesvm, string rutaPrincipal, Microsoft.AspNetCore.Http.IFormFileCollection archivos)
        {
            string nombreArchivo = Guid.NewGuid().ToString();
            var subidas = Path.Combine(rutaPrincipal, @"imagenes\clientes");
            var extension = Path.GetExtension(archivos[0].FileName);

            using (var fileStreams = new FileStream(Path.Combine(subidas, nombreArchivo + extension), FileMode.Create))
            {
                archivos[0].CopyTo(fileStreams);
            }

        }



        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ClientesVM clientesvm = new ClientesVM()
            {
                Clientes = new Models.Clientes(),
                ListaCiudad = _contenedorTrabajo.Ciudad.GetListaCiudad(),
                ListaVendedor = _contenedorTrabajo.Vendedor.GetListaVendedor(),
                ListaTipoGranContribuyente = _contenedorTrabajo.TipoGranContribuyente.GetListaTipoGranContribuyente(),

            };
            if (id != null)
            {
                clientesvm.Clientes = _contenedorTrabajo.Clientes.Get(id.GetValueOrDefault());
            }
            return View(clientesvm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ClientesVM clientesvm)
        {
            if (ModelState.IsValid)
            {
                string rutaPrincipal = _hostingEnvironment.WebRootPath;
                var archivos = HttpContext.Request.Form.Files;

                var clientesDesdeDb = _contenedorTrabajo.Clientes.Get(clientesvm.Clientes.ClienteId);
                if (archivos.Count() > 0)
                {
 

                    _contenedorTrabajo.Clientes.Update(clientesvm.Clientes);
                    _contenedorTrabajo.Save();

                    return RedirectToAction(nameof(Index));
                }
 
                _contenedorTrabajo.Clientes.Update(clientesvm.Clientes);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        private static void EditarImagenClientes(ClientesVM clientesvm, string rutaPrincipal, Microsoft.AspNetCore.Http.IFormFileCollection archivos, Models.Clientes clientesDesdeDb)
        {
            string nombreArchivo = Guid.NewGuid().ToString();
            var subidas = Path.Combine(rutaPrincipal, @"imagenes\clientes");
            var extension = Path.GetExtension(archivos[0].FileName);
            var nuevaExtension = Path.GetExtension(archivos[0].FileName);

 

            //subimos nuevamente el archivo
            using (var fileStreams = new FileStream(Path.Combine(subidas, nombreArchivo + nuevaExtension), FileMode.Create))
            {
                archivos[0].CopyTo(fileStreams);
            }
 
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var clientesDesdeDb = _contenedorTrabajo.Clientes.Get(id);
            string rutaDirectorioPrincipal = _hostingEnvironment.WebRootPath;

  

            if (clientesDesdeDb == null)
            {
                return Json(new { success = false, message = "Error borrando artículo"});
            }

            _contenedorTrabajo.Clientes.Remove(clientesDesdeDb);
            _contenedorTrabajo.Save();
            return Json(new { success = true, message = "Clientes borrado con éxito" });

        }


        #region LLAMADAS A LA API Clientes
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.Clientes.GetAll(includeProperties: "Ciudad,Vendedor,TipoGranContribuyente") });
        }        
        #endregion

    }
}
