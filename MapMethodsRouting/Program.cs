using System;

namespace MapMethodsRouting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/Home",(context) is request ke upar context.Response.WriteAsJsonAsync yah request function chalega
                //yah Asynchronously kaam karta h isiliye await lagayenge

                endpoints.MapGet("/Home",async (context)=>
                 {
                     await context.Response.WriteAsync("This is Home Page Get");


                 });

                endpoints.MapPost("/Home", async (context) =>
                {
                    await context.Response.WriteAsync("This is Home Page Post");


                });

                endpoints.MapPut("/Home", async (context) =>
                {
                    await context.Response.WriteAsync("This is Home Page Put");


                });

            /*async (context) =>
            {
                await context.Response.WriteAsync("This is Home Page Delete");


            }); */
            //isi ko basically request delegate kahte h

            endpoints.MapDelete("/Home", async (context) =>
                {
                    await context.Response.WriteAsync("This is Home Page Delete");


                });

            });

            app.Run(async(HttpContext context) =>
            {
                await context.Response.WriteAsync("Page Not Found");

            });

            //app.Map("/Home", () => "Hello World!");

            //app.MapGet("/Home", () => "Hello World! - GET");
            //app.MapPost("/Home", () => "Hello World! - Post");
            //app.MapPut("/Home", () => "Hello World! - Put");
            //app.MapDelete("/Home", () => "Hello World! - Delete");

            app.Run();
        }
    }
}
