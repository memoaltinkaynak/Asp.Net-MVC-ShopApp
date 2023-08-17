using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using ShopApp.Business.Abstract;
using ShopApp.Business.Concrete;
using ShopApp.Data.Absctract;
using ShopApp.Data.Concrete.EfCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp
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
            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
            services.AddScoped<IProductRepository , EfCoreProductRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddControllersWithViews();
            //services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles(); //wwwroot

           // app.UseStaticFiles(new StaticFileOptions
           // {
           //     FileProvider = new PhysicalFileProvider(
           //Path.Combine(Directory.GetCurrentDirectory(), "wwwwroot")),
           //     RequestPath = "/modules"
           // });

            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "adminproducts",
                   pattern: "admin/products",
                   defaults: new { controller = "Admin", action = "ProductList" }
               );

                endpoints.MapControllerRoute(
                    name: "adminproductcreate",
                    pattern: "admin/products/create",
                    defaults: new { controller = "Admin", action = "ProductCreate" }
                );

                endpoints.MapControllerRoute(
                    name: "adminproductedit",
                    pattern: "admin/products/{id?}",
                    defaults: new { controller = "Admin", action = "ProductEdit" }
                );

                endpoints.MapControllerRoute(
                   name: "admincategories",
                   pattern: "admin/categories",
                   defaults: new { controller = "Admin", action = "CategoryList" }
               );

                endpoints.MapControllerRoute(
                    name: "admincategorycreate",
                    pattern: "admin/categories/create",
                    defaults: new { controller = "Admin", action = "CategoryCreate" }
                );

                endpoints.MapControllerRoute(
                    name: "admincategoryedit",
                    pattern: "admin/categories/{id?}",
                    defaults: new { controller = "Admin", action = "CategoryEdit" }
                );


                // localhost/search    
                endpoints.MapControllerRoute(
                    name: "search",
                    pattern: "search",
                    defaults: new { controller = "Shop", action = "search" }
                );

                endpoints.MapControllerRoute(
                    name: "productdetails",
                    pattern: "{url}",
                    defaults: new { controller = "Shop", action = "details" }
                );

                endpoints.MapControllerRoute(
                    name: "products",
                    pattern: "products/{category?}",
                    defaults: new { controller = "Shop", action = "list" }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );

                //endpoints.MapControllerRoute(
                //         name: "admincategorylist",
                //         pattern: "admin/categories",
                //         defaults: new { controller = "Admin", action = "CategoryList" }
                //     );

                // endpoints.MapControllerRoute(
                //         name: "adminproductlist",
                //         pattern: "admin/products",
                //         defaults: new { controller = "Admin", action = "ProductList" }
                //     ); 

                // endpoints.MapControllerRoute(
                //         name: "admincategorylist",
                //         pattern: "admin/categories/{id?}",
                //         defaults: new { controller = "Admin", action = "CategoryEdit" }
                //     );

                // endpoints.MapControllerRoute(
                //         name: "adminproductlist",
                //         pattern: "admin/products/{id?}",
                //         defaults: new { controller = "Admin", action = "ProductEdit" }
                //     );

                // endpoints.MapControllerRoute(
                //         name: "search",
                //         pattern: "search",
                //         defaults: new { controller = "Shop", action = "search" }
                //     );

                // endpoints.MapControllerRoute(
                //         name: "productdetails",
                //         pattern: "{url}",
                //         defaults: new { controller = "Shop", action = "details" }
                //     );

                // endpoints.MapControllerRoute(
                //         name: "products",
                //         pattern: "products/{category?}",
                //         defaults: new {controller="Shop", action="list"}
                //     );        

                // endpoints.MapControllerRoute(
                //     name: "default" ,
                //     pattern:"{controller=Home}/{action=Index}/{id?}"

                //     );
            });
        }
    }
}
