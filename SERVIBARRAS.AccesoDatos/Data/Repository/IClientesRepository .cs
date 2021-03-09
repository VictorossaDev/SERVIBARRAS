using System;
using System.Text;
using SERVIBARRAS.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SERVIBARRAS.AccesoDatos.Data.Repository
{
    public interface IClientesRepository : IRepository<Clientes>
    {
        IEnumerable<SelectListItem> GetListaClientes();

        void Update(Clientes clientes);
    }
}
