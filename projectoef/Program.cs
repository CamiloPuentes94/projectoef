using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using projectoef;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);
// configuracion de base de datos en en memoria
//builder.Services.AddDbContext<TareaContext>(item => item.UseInMemoryDatabase("TareasDB"));

// Configuracion de base de datos postgres
builder.Services.AddNpgsql<TareaContext>(builder.Configuration.GetConnectionString("conexionTareas"));


var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async ([FromServices] TareaContext dbcontext) =>
{
    dbcontext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria" + dbcontext.Database.IsInMemory());
});


app.Run();
app.Run();