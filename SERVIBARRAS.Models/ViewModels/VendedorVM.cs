using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVIBARRAS.Models.ViewModels
{
    // Debe ser una clase publica
    public class VendedorVM
    {
        public Vendedor Vendedor { get; set; }
        // Para combobox
        public IEnumerable<SelectListItem> ListaVendedor { get; set; }
    }
}



