// Tabla Dependiente Clientes
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SERVIBARRAS.Models;
using SERVIBARRAS.AccesoDatos.Data.Repository;

namespace SERVIBARRAS.AccesoDatos.Data
{
    public class ClientesRepository : Repository<Clientes>, IClientesRepository
    {
        private readonly ApplicationDbContext _db;

        public ClientesRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        // Para implementar en un combobox una seleccion de elementos de la entidad, nombre y el value
        public IEnumerable<SelectListItem> GetListaClientes()
        {
            return _db.Clientes.Select(i => new SelectListItem() { 
                Text = i.RazonSocial,
                Value = i.ClienteId.ToString()
            });
        }
        // Para actualizacion singular de la entidad, por buena practica debe de estar aqui y no en  el generico
        public void Update(Clientes clientes)
        {
            var objDesdeDb = _db.Clientes.FirstOrDefault(s => s.ClienteId == clientes.ClienteId);
            objDesdeDb.RazonSocial = clientes.RazonSocial;
            objDesdeDb.Nit = clientes.Nit;
            objDesdeDb.Direccion = clientes.Direccion;
            objDesdeDb.FechaIngreso = clientes.FechaIngreso;
            objDesdeDb.CiudadId = clientes.CiudadId;
            objDesdeDb.VendedorId = clientes.VendedorId;
            objDesdeDb.Email = clientes.Email;
            objDesdeDb.Cupo = clientes.Cupo;
            objDesdeDb.Plazo = clientes.Plazo;
            objDesdeDb.TipoGranContribuyenteId = clientes.TipoGranContribuyenteId;
            objDesdeDb.MarcaDeExtranjero  = clientes.MarcaDeExtranjero ;

            _db.SaveChanges();
        }
    }
}


