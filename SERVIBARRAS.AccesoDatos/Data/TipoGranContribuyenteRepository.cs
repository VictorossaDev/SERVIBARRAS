// Tabla Independiente TipoGranContribuyente
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using SERVIBARRAS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using SERVIBARRAS.AccesoDatos.Data.Repository;

namespace SERVIBARRAS.AccesoDatos.Data
{
    public class TipoGranContribuyenteRepository : Repository<TipoGranContribuyente>, ITipoGranContribuyenteRepository
    {
        private readonly ApplicationDbContext _db;

        public TipoGranContribuyenteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        // Para implementar en un combobox una seleccion de elementos de la entidad, nombre y el value
        public IEnumerable<SelectListItem> GetListaTipoGranContribuyente()
        {
            return _db.TipoGranContribuyente.Select(i => new SelectListItem() { 
                Text = i.NombreTipoGranContribuyente,
                Value = i.TipoGranContribuyenteId.ToString()
            });
        }
        // Para actualizacion singular de la entidad, por buena practica debe de estar aqui y no en  el generico
        public void Update(TipoGranContribuyente tipograncontribuyente)
        {
            var objDesdeDb = _db.TipoGranContribuyente.FirstOrDefault(s => s.TipoGranContribuyenteId == tipograncontribuyente.TipoGranContribuyenteId);
            objDesdeDb.NombreTipoGranContribuyente = tipograncontribuyente.NombreTipoGranContribuyente;

            _db.SaveChanges();
        }
    }
}


