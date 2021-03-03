using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVIBARRAS.Models.ViewModels
{
    // Debe ser una clase publica
    public class CiudadVM
    {
        public Ciudad Ciudad { get; set; }
        // Para combobox
        public IEnumerable<SelectListItem> ListaCiudad { get; set; }
    }
}



