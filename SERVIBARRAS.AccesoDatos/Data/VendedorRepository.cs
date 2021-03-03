// Tabla Independiente Vendedor
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using SERVIBARRAS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using SERVIBARRAS.AccesoDatos.Data.Repository;

namespace SERVIBARRAS.AccesoDatos.Data
{
    public class VendedorRepository : Repository<Vendedor>, IVendedorRepository
    {
        private readonly ApplicationDbContext _db;

        public VendedorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        // Para implementar en un combobox una seleccion de elementos de la entidad, nombre y el value
        public IEnumerable<SelectListItem> GetListaVendedor()
        {
            return _db.Vendedor.Select(i => new SelectListItem() { 
                Text = i.NombreVendedor,
                Value = i.VendedorId.ToString()
            });
        }
        // Para actualizacion singular de la entidad, por buena practica debe de estar aqui y no en  el generico
        public void Update(Vendedor vendedor)
        {
            var objDesdeDb = _db.Vendedor.FirstOrDefault(s => s.VendedorId == vendedor.VendedorId);
            objDesdeDb.NombreVendedor = vendedor.NombreVendedor;

            _db.SaveChanges();
        }
    }
}


