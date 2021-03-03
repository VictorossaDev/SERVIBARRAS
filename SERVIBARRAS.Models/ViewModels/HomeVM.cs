
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVIBARRAS.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Slider { get; set; }
        public IEnumerable<Vendedor> ListaVendedor { get; set; }
        public IEnumerable<TipoGranContribuyente> ListaTipoGranContribuyente { get; set; }
        public IEnumerable<Ciudad> ListaCiudad { get; set; }
        public IEnumerable<Clientes> ListaClientes { get; set; }    
        public IEnumerable<Articulo> ListaArticulos { get; set; }
}

}