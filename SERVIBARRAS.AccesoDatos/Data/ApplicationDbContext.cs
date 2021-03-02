
using System;
using System.Collections.Generic;
using System.Text;
using SERVIBARRAS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

          /* En caso de querer hacer una migracion deben de existir aqui las entidades y este se debe de generar desde el
               proyecto de acceso a datos*/

          
        // public DbSet<Categoria> Categoria { get; set; }

        // public DbSet<Articulo> Articulo { get; set; }
   
        // public DbSet<Slider> Slider { get; set; }
        // public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
