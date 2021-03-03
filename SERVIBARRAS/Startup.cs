using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SERVIBARRAS.AccesoDatos.Data;
using SERVIBARRAS.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Identity.UI.Services;
using SERVIBARRAS.Utilidades;
using SERVIBARRAS.Models;
using SERVIBARRAS.AccesoDatos.Data.Inicializador;

namespace SERVIBARRAS
{
    public class Startup
    {
        // Recibimos el IConfiguration para tener acceso a las fuentes de configuracion de la aplicacion
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // Aqui es donde configuramos los componentes comunes de la aplicacion que se utilizan en distintas partes de la aplicacion
        public void ConfigureServices(IServiceCollection services)
        {
            // Mecanismo por el cual EF se puede comunicar con una base de datos 
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddSingleton<IEmailSender, EmailSender>();

            // Para la inyeccion de dependencia utilizando el contenedor de trabajo como servicio general, inyectamos todas las dependencias
            // que contenga este servicio
            services.AddScoped<IContenedorTrabajo, ContenedorTrabajo>();

            // Importa la inicializacion de la aplicacion cuando se hace por primera vez o se despliega
            services.AddScoped<IInicializadorDB, InicializadorDB>();

            // Runtime para compilacion, en etapa de desarrollo para ir viendo reflejados los cambios
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IInicializadorDB dbInicial)
        {
            // Configuracion de variables de ambiente,para la captura de errores en desarrollo
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            dbInicial.Inicializar();
            app.UseAuthentication();
            app.UseAuthorization();
            
            // Reglas de ruteo de la aplicacion
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{area=Cliente}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}

