using BrechoModelo.Infrastructure.CrossCutting.IOC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace BrechoAPI
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        private void RegisterServices(IServiceCollection services)
        {
            ConfigurationIOC.RegisterServices(services, Configuration.GetConnectionString("SqlConnectionString"), Configuration);
        }
        public void ConfigureServices(IServiceCollection services)
        {

            RegisterServices(services);
            //var connection = Configuration["sqlConnection:SqlConnectionString"];
            //services.addDbContext<SqlContext>(options => options.UseSqlServer(connection));
            //services.AddDbContext<SqlContext>(options => options.UseSqlServer(connection));
            //services.AddControllers();
            //services.AddTransient<IClienteAplicationService, ClienteAplicationService>();
            //services.AddTransient<IProdutoAplicationService, ProdutoAplicationService>();
            //services.AddTransient<IProdutoAplicationService, ProdutoAplicationService>();
            //services.AddSingleton<IClienteMapper, ClienteMapper>();
            //services.AddSingleton<IProdutoMapper, ProdutoMapper>();
            //services.AddTransient<IClienteRepository, ClienteRepository>();
            //services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BrechoAPI", Version = "v1" });
            });
        }
        //public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }



        //public static void RegisterServices(IServiceCollection services, string connectionString, IConfiguration Configuration)
        //{
        //    services.AddDbContext<SqlContext>(options =>
        //    {
        //        options.UseSqlServer(connectionString);
        //    });
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BrechoAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
