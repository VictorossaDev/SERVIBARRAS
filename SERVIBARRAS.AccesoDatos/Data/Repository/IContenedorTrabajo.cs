using SERVIBARRAS.AccesoDatos.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVIBARRAS.AccesoDatos.Data.Repository
{
    public interface IContenedorTrabajo : IDisposable
    {
      // Aqui se nombran todos los repositorios 
      
        IVendedorRepository Vendedor { get; }
        ITipoGranContribuyenteRepository TipoGranContribuyente { get; }
        ICiudadRepository Ciudad { get; }
        IClientesRepository Clientes { get; }    
        ICategoriaRepository Categoria { get; }
        IArticuloRepository Articulo { get; }
        ISliderRepository Slider { get; }
        IUsuarioRepository Usuario { get; }
        void Save();
    }
}
