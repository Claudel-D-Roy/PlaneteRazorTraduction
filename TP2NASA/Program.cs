using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Globalization;
using TP2NASA.Data;
using TP2NASA.Services;
/// <summary>
/// Auteur: Claudel D. Roy, Willaim Jubinville, Mathieu Duval
/// Description: Collection de tous les services pour les pages du site.
/// Date: 11-25-2022
/// </summary>
/// 
var builder = WebApplication.CreateBuilder(args);

#region Services
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IPubService, PubService>();
builder.Services.AddScoped<IPlanèteService>(service => new PlanèteService(IPlanèteService.Mode.BD, service.GetRequiredService<PlanètesContext>()));
builder.Services.AddDbContext<PlanètesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PlanètesContext")!.Replace("[PROJET]", builder.Environment.ContentRootPath)));

//pour la langue
builder.Services.Configure<RequestLocalizationOptions>(
options =>
{
    var supportedCultures = new[] {
new CultureInfo("en"),
new CultureInfo("fr"),
};
    options.DefaultRequestCulture = new RequestCulture("fr");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddMvc().AddViewLocalization()
    .AddDataAnnotationsLocalization();
#endregion

var app = builder.Build();

#region Intergiciels
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();
//pour la langue
app.UseRequestLocalization(app.Services.GetService<IOptions<RequestLocalizationOptions>>()!.Value);

app.UseAuthorization();
#endregion

string sAuteur = builder.Configuration["Application:Auteur"];

#region Points de terminaison
app.MapRazorPages();
#endregion

app.Run();
