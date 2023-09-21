using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectoef;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TareaContext>(item => item.UseInMemoryDatabase("TareasDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async ([FromServices] TareaContext dbcontext) =>
{
    dbcontext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria" + dbcontext.Database.IsInMemory());
});


app.Run();
