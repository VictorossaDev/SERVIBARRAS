using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace SERVIBARRAS.Models.ViewModels
{
    // Debe ser una clase publica
    public class ClientesVM
    {
        public Clientes Clientes{ get; set; }
         // Listas
        public IEnumerable<SelectListItem> ListaCiudad { get; set; }

        public IEnumerable<SelectListItem> ListaVendedor { get; set; }

        public IEnumerable<SelectListItem> ListaTipoGranContribuyente { get; set; }


    }
}