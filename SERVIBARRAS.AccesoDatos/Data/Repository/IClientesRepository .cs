using SERVIBARRAS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVIBARRAS.AccesoDatos.Data.Repository
{
    public interface IClientesRepository : IRepository<Clientes>
    {
        IEnumerable<SelectListItem> GetListaClientes();

        void Update(Clientes clientes);
    }
}
