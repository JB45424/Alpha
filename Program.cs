using Alpha.Data;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<AlphaContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("AlphaConnection"));
});

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();
