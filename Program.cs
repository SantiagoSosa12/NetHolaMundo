// Usign para anadir dependencias

using Microsoft.EntityFrameworkCore;
using holaMundo.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Conectar con la BD
const string CONNECTIONNAME = "UniversityBD";
var conectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);


// Anadir contexto a Builder

builder.Services.AddDbContext<UniversityBDContext>(options => options.UseSqlServer(conectionString));

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
