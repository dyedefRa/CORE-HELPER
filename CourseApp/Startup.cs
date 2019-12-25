using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CourseApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Mvc Eklemek için bunu ekledik.
            services.AddMvc()
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                // await context.Response.WriteAsync("Hello World!!");
                //Ne gelirse gelsin Response Hello World yazıyor 

                //Default Route oluştur.
                // app.UseMvcWithDefaultRoute();
                // localhost/controller/action/id

                //Yada manual oluştur
                app.UseMvc(routes=>{
                    routes.MapRoute(
                        name:"default",
                        template:"{controller}/{action}/{id?}"
                    );
                });
            });
        }
    }
}
