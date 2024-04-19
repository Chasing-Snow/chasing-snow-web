using Chasing
using Microsoft.Extensions.Options;

-Snow.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(options => 
    options.UseSqlite("Data Source = ../Registrar.sqlite",
    b => b.MigrationsAssembly("Chasing-Snow.Api")) 
    );
    builder.Services.addCors(Options =>
    {
        Options.AddDefaultPolicy(builder => 
        {
            builder.withOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();