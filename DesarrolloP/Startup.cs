//using Business.Implementations;
//using Business.Interfaces;
//using Infrastructure.DBContext;
//using Infrastructure.Models;
using Business.Implementations;
using Business.Interfaces;
using Infraestrucuta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Business.Interfaces;
//using WebApplication1.Models;
//using Microsoft.OpenApi.Models;

namespace DesarrolloP
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {



            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DesarrolloP", Version = "Cristian Pabon" });
            });

            services.AddTransient<IPersonaServices, PersonaServices>();
            services.AddTransient<IUsuarioServices, UsuarioService>();
            //services.AddScoped<IAswServices, AswServices>();
            //services.AddTransient<IPersonaServices, PersonaServices>();



            services.AddDbContext<Desarrollo_plataformasContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Scoped);

            //permitir que otras aplicaciones consuman esta API
            services.AddCors(options => options.AddPolicy("", builder => builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()));

            services.AddCors(options => {
                options.AddPolicy("AllowWebApp", builder => builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());


            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiPruebas"));
            }

            //permitir que otras aplicaciones consuman esta API
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllers();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "usuario-mi-nuevo-endpoint",
                    pattern: "Usuario/MiNuevoEndpoint",
                    defaults: new { controller = "UsuarioController", action = "MiNuevoEndpoint" });

                endpoints.MapControllers();
            });
        }
    }
}
