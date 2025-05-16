using FielApi.Infrastructure.persistance.data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder);

var app = builder.Build();



app.MapGet("/", () => "Hello World!");
app.Run();

void ConfigureServices(WebApplicationBuilder builder)
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    builder.Services.AddDbContext<FielDbContext>(options => options.UseNpgsql(connectionString));

}
