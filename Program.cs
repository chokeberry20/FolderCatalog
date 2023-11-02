using FolderCatalog.Data;
using FolderCatalog.Interfaces;
using FolderCatalog.Repository;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));    
});
builder.Services.AddScoped<IFolderRepository, FolderRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();
