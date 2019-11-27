using ControleDeGastos.Repository;
using ControleDeGastos.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeGastos.Api
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
            services.AddScoped<CartaoService>();
            services.AddScoped<CategoriaService>();
            services.AddScoped<LancamentoService>();
            services.AddScoped<UsuarioService>();
            services.AddScoped<RecebimentoService>();

            services.AddScoped<CartaoRepository>();
            services.AddScoped<CategoriaRepository>();
            services.AddScoped<LancamentoRepository>();
            services.AddScoped<RecebimentoRepository>();
            services.AddScoped<UsuarioRepository>();

            services.AddDbContext<Context>
                (options => options.UseSqlServer
                (Configuration.GetConnectionString
                ("ControleDeGastosConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
        }
    }
}
