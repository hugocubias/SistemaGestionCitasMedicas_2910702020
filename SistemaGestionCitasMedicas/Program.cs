using SistemaGestionCitasMedicas.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar soporte para controladores con vistas
builder.Services.AddControllersWithViews();

// Conexión a la base de datos
builder.Services.AddDbContext<ClinicaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ClinicaContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
