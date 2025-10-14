using FutebolApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Pega a string de conexão do appsettings.json
var connectionString = builder.Configuration.GetConnectionString("Futebol");

// Adiciona os serviços do Entity Framework e configura o DbContext
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// GET all
app.MapGet("/times", async (AppDbContext db) =>
{
    return await db.Times.ToListAsync();
});

// GET por ID
app.MapGet("/times/{id}", async (int id, AppDbContext db) =>
{
    var time = await db.Times.FindAsync(id);
    return time is not null ? Results.Ok(time) : Results.NotFound("Time não encontrado!");
});

app.Run();
