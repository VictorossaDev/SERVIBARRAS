using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SERVIBARRAS.Models;
using SERVIBARRAS.AccesoDatos.Data.Repository;
using SERVIBARRAS.Models.ViewModels;

namespace SERVIBARRAS.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public HomeController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }

        public IActionResult Index()
        {
            HomeVM homeVm = new HomeVM()
            {
                Slider = _contenedorTrabajo.Slider.GetAll(),
                ListaVendedor = _contenedorTrabajo.Vendedor.GetAll(),
                ListaTipoGranContribuyente = _contenedorTrabajo.TipoGranContribuyente.GetAll(),
                ListaCiudad = _contenedorTrabajo.Ciudad.GetAll(),
                ListaClientes = _contenedorTrabajo.Clientes.GetAll(),
                ListaArticulos = _contenedorTrabajo.Articulo.GetAll()
            };
            return View(homeVm);
        }

        public IActionResult Error()
        {
            return View();
        }

        // OPCIONAL
        public IActionResult Details(int id)
        {
            var articuloDesdeDb = _contenedorTrabajo.Articulo.GetFirstOrDefault(a => a.Id == id);
            return View(articuloDesdeDb);
        }       
    }
}