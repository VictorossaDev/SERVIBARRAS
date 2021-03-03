using SERVIBARRAS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVIBARRAS.AccesoDatos.Data.Repository
{
    public interface ITipoGranContribuyenteRepository : IRepository<TipoGranContribuyente>
    {
        IEnumerable<SelectListItem> GetListaTipoGranContribuyente();

        void Update(TipoGranContribuyente tipograncontribuyente);
    }
}
