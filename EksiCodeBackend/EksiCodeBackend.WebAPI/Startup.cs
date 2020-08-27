using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using EksiCodeBackend.Business.Abstract;
using EksiCodeBackend.Business.Concrete;
using EksiCodeBackend.DataAccess.Abstract;
using EksiCodeBackend.DataAccess.Concrete;
using Microsoft.OpenApi.Models;

namespace EksiCodeBackend.WebAPI
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
            /*services.AddDbContext<EksiCodeBackend.DataAccess.EksiCodeBackendContext> (opt => {
                opt.UseMySql (Configuration.GetConnectionString ("DefaultConnection"));
            });*/

            //var configurationSection = Configuration.GetSection("ConnectionStrings:LocalConnection");
            services.AddDbContext<DataAccess.EksiCodeBackendContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DevConnection"))
            );

            services.AddSwaggerGen(c=> { 
                c.SwaggerDoc("CoreSwagger", new OpenApiInfo
                {
                    Title = "Swagger on ASP.NET Core",
                    Version = "1.0.0",
                    Description = "Try Swagger on, (ASP.NET Core 3.1)"
                });
            });


            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) 
            {
                app.UseDeveloperExceptionPage();
            }
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DataAccess.EksiCodeBackendContext>();
                context.Database.EnsureCreated();
            }

            app.UseSwagger()
            .UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/CoreSwagger/swagger.json", "Swagger Test .Net Core");
            });

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
