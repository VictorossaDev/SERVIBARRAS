using SERVIBARRAS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVIBARRAS.AccesoDatos.Data.Repository
{
    public interface ICiudadRepository : IRepository<Ciudad>
    {
        IEnumerable<SelectListItem> GetListaCiudad();

        void Update(Ciudad ciudad);
    }
}
