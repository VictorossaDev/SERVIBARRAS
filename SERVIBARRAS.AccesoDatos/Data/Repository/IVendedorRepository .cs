using SERVIBARRAS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVIBARRAS.AccesoDatos.Data.Repository
{
    public interface IVendedorRepository : IRepository<Vendedor>
    {
        IEnumerable<SelectListItem> GetListaVendedor();

        void Update(Vendedor vendedor);
    }
}
