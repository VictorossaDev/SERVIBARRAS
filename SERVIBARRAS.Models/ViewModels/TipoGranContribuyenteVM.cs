using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVIBARRAS.Models.ViewModels
{
    // Debe ser una clase publica
    public class TipoGranContribuyenteVM
    {
        public TipoGranContribuyente TipoGranContribuyente { get; set; }
        // Para combobox
        public IEnumerable<SelectListItem> ListaTipoGranContribuyente { get; set; }
    }
}



