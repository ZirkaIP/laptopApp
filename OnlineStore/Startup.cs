using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Data;
using OnlineStore.Data.Interfaces;
using OnlineStore.Data.Models;
using OnlineStore.Data.Repository;

namespace OnlineStore
{
    public class Startup
    {
        private IConfigurationRoot confString;

        public Startup(IHostingEnvironment hostEnvr)
        {
                confString = new ConfigurationBuilder().SetBasePath(hostEnvr.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContent>(options => options.UseSqlServer(confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllLaptops, LaptopRepository>();
            services.AddTransient<ILaptopsCategory, CategoryRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));
            services.AddMvc();

            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
        
                app.UseDeveloperExceptionPage();
                app.UseDefaultFiles();
                app.UseStatusCodePages();
                app.UseStaticFiles();
                app.UseSession();
                app.UseMvcWithDefaultRoute();
                app.UseMvc(routes =>
                  {
                      routes.MapRoute(name: "default", template: "home/index/{id?}");
                      routes.MapRoute(name: "categoryFilter", template: " laptops/{action}/{Category?}", defaults: new { Controller = "Laptops", action="List"});
                  });

                    AppDbContent content;

                    using (var scope = app.ApplicationServices.CreateScope())
                    {
                        content = scope.ServiceProvider.GetRequiredService<AppDbContent>();
                        DbObjects.Initial(content);
                    }
        }
    }
}
