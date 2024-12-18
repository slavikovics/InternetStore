
using InternetStore;
using Microsoft.EntityFrameworkCore;

namespace InternetStoreWebApp
{
    public class Program
    {
        static List<PowerSupply> powerSupplies = new List<PowerSupply>();
 
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<Context>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;MultipleActiveResultSets=true"));
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
