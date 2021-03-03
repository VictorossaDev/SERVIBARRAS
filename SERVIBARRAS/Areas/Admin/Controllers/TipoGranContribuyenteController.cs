// Tabla Independiente => TipoGranContribuyente
using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

using SERVIBARRAS.Models;
using SERVIBARRAS.AccesoDatos.Data.Repository;

namespace SERVIBARRAS.Areas.Admin.Controllers
{
    // Solicitara autorizacion al acceso al controlador segun el rol del usuario, para que este protegido
    [Authorize]
    // Area a la que pertenece el controlador
    [Area("Admin")]
    public class TipoGranContribuyenteController : Controller
    {
        // Instanciamos el contenedor de trabajo que es donde tenemos todos los repositorios
        private readonly IContenedorTrabajo _contenedorTrabajo;
        // En caso de que el modelo tenga un campo tipo imagen
        private readonly IWebHostEnvironment _hostingEnvironment;

        // Contructor de la clase para acceder a todas las entidades
        public TipoGranContribuyenteController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironment)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironment;
        }

        // Inicio de Formulario
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Inicio de Formulario de Creacion
        [HttpGet]
        public IActionResult Create()
        {           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TipoGranContribuyente tipograncontribuyente)
        {
            if (ModelState.IsValid)
            {             

                _contenedorTrabajo.TipoGranContribuyente.Add(tipograncontribuyente);
                _contenedorTrabajo.Save();

                return RedirectToAction(nameof(Index));

            }
            return View();
        }
        // Metodo para Crear Imagen
        private void ConCreacionDeImagen(TipoGranContribuyente tipograncontribuyente)
        {
            string rutaPrincipal = _hostingEnvironment.WebRootPath;
            var archivos = HttpContext.Request.Form.Files;

            //Nueva Imagen de TipoGranContribuyente
            string nombreArchivo = Guid.NewGuid().ToString();
            var subidas = Path.Combine(rutaPrincipal, @"imagenes\tipograncontribuyente");
            var extension = Path.GetExtension(archivos[0].FileName);

            using (var fileStreams = new FileStream(Path.Combine(subidas, nombreArchivo + extension), FileMode.Create))
            {
                archivos[0].CopyTo(fileStreams);
            }


        }

        // Carga El Formulario de Edicion por convencion el parametro debera llamarce id si que si....
        [HttpGet]
        public IActionResult Edit(int? id)
        {          
            if (id != null)
            {
                var tipograncontribuyente = _contenedorTrabajo.TipoGranContribuyente.Get(id.GetValueOrDefault());
                return View(tipograncontribuyente);
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TipoGranContribuyente tipograncontribuyente)
        {
            if (ModelState.IsValid)
            {
                string rutaPrincipal = _hostingEnvironment.WebRootPath;
                var archivos = HttpContext.Request.Form.Files;

                var tipograncontribuyenteDesdeDb = _contenedorTrabajo.TipoGranContribuyente.Get(tipograncontribuyente.TipoGranContribuyenteId);

                if (archivos.Count() > 0)
                {

                    _contenedorTrabajo.TipoGranContribuyente.Update(tipograncontribuyente);
                    _contenedorTrabajo.Save();

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    //Aquí es cuando la imagen ya existe se conserva la misma

                }

                _contenedorTrabajo.TipoGranContribuyente.Update(tipograncontribuyente);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // Actualiza imagen que este en base de datos
        private static void EditarImagenGuardada(TipoGranContribuyente tipograncontribuyente, string rutaPrincipal, Microsoft.AspNetCore.Http.IFormFileCollection archivos, TipoGranContribuyente tipograncontribuyenteDesdeDb)
        {
            string nombreArchivo = Guid.NewGuid().ToString();
            var subidas = Path.Combine(rutaPrincipal, @"imagenes\tipograncontribuyente");
            var nuevaExtension = Path.GetExtension(archivos[0].FileName);

            //Aquí subimos nuevamente el archivo
            using (var fileStreams = new FileStream(Path.Combine(subidas, nombreArchivo + nuevaExtension), FileMode.Create))
            {
                archivos[0].CopyTo(fileStreams);
            }

        }       
        
        #region LLAMADAS A LA API TABLA TipoGranContribuyente
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.TipoGranContribuyente.GetAll() });
        }
        // Para la eliminacion por convencion el parametro debera llamarce id si que si....
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _contenedorTrabajo.TipoGranContribuyente.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error borrando TipoGranContribuyente" });
            }
            _contenedorTrabajo.TipoGranContribuyente.Remove(objFromDb);
            _contenedorTrabajo.Save();
            return Json(new { success = true, message = "TipoGranContribuyente borrado correctamente" });
        }
        #endregion
    }
}

