using DesignPattern.Core.Interfaces;
using DesignPattern.Core.Services;

namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();


            builder.Services.AddScoped<IProductService, ProductService>();
            
            
            var app = builder.Build();


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            app.Run();
        }
    }
}
