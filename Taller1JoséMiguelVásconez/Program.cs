﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EstadioContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EstadioContext") ?? throw new InvalidOperationException("Connection string 'EstadioContext' not found.")));
builder.Services.AddDbContext<EquipoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EquipoContext") ?? throw new InvalidOperationException("Connection string 'EquipoContext' not found.")));
builder.Services.AddDbContext<JugadoresContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JugadoresContext") ?? throw new InvalidOperationException("Connection string 'JugadoresContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
