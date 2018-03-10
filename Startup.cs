using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace barry_http_dotnetcore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                context.Response.StatusCode = 403;
                var contentType = context.Request.Headers["Content-Type"];
                
                if (contentType.Contains("application/json")) {
                    context.Response.Headers["Content-Type"] = "application/json";
                    await context.Response.WriteAsync("{\"error\":\"INVALID AND UNSECURE REQUEST\"}\r\n");
                }
                else if (contentType.Contains("text/plain")) {
                    await context.Response.WriteAsync("INVALID AND UNSECURE REQUEST\r\n");
                }
                else {
                    var image = System.IO.File.OpenRead("./images/barry-unauthorized2.jpg");
                    context.Response.Headers["Content-Type"] = "image/png";
                    await image.CopyToAsync(context.Response.Body);
                }
            });
        }
    }
}
