using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UrlRouting.WebUI.Customize;

namespace UrlRouting.WebUI
{
    public class Startup
    {
        public IConfiguration _configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();

            //app.UseMvc(route => route.MapRoute(
            //    name: "default",
            //    template: "{Controller=Home}/{Action=Index}/{id?}")
            //    );

            //app.UseMvc(route => route.MapRoute(
            //               name: "default",
            //               template: "{Controller}/{Action}/{id?}",
            //               defaults:new { action = "Index" })
            // );

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                       name: "Shop2",
                       template: "shop/newest",
                       defaults: new { controller = "Product", action = "Index" }); // localhost/shop/Index  
                routes.MapRoute(
                       name: "Shop1",
                       template: "shop/{action}",
                       defaults: new { controller = "Product" }); // localhost/shop/index    localhost/shop/list        
                routes.MapRoute(
                       name: "aRoute",
                       template: "a{controller}/{action}"); // localhost/aproduct/index  
                routes.MapRoute(
                       name: "catalog",
                       template: "catalog/{controller}/{action=Index}");  // localhost/catalog/product/index?
                //routes.MapRoute(
                //       name: "default",
                //       template: "{controller=Home}/{action=Index}/{id?}"); ///product/details/5
                //ROUTE CONSTRAINT 
                routes.MapRoute(
                      name: "default",
                      template: "{controller=Home}/{action=Index}/{id:int?}"); // http://localhost:61018/product/details/5a OKEY |  http://localhost:61018/product/details/5a FAIL
                routes.MapRoute(
                     name: "default2",
                     template: "{controller}/{action}/{id?}",
                     defaults: new { controller = "Home", action = "Index" },
                     constraints: new { id = new IntRouteConstraint() });
                //CUSTOM ROUTE CONSTRAINT
                routes.MapRoute(
                    name: "custom1",
                    template: "custom/{controller}/{action}/{id?}",
                    defaults: new { controller = "Product", action = "Details" },
                    constraints: new { id = new weekdayConstraint() });  //http://localhost:61018/custom/Product/Details/car
            });
            // catalog=>  "/catalog/product" ,"/catalog/home"







            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
