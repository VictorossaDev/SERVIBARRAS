
using SERVIBARRAS.AccesoDatos.Data.Repository.IRepository;
using SERVIBARRAS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SERVIBARRAS.AccesoDatos.Data.Repository
{
    public class SliderRepository : Repository<Slider> , ISliderRepository
    {
        private readonly ApplicationDbContext _db;

        public SliderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Slider slider)
        {
            var objDesdeDb = _db.Slider.FirstOrDefault(s => s.Id == slider.Id);
            objDesdeDb.Titulo = slider.Titulo;
            objDesdeDb.Contenido = slider.Contenido;
            objDesdeDb.UrlImagen = slider.UrlImagen;
            _db.SaveChanges();
        }
    }
}

