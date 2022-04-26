using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SuperheroStats.Data;
using SuperheroStats.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddHttpClient<_IHeroService, _HeroService>(client =>
//{
//    client.BaseAddress = new Uri("https://superhero-search.p.rapidapi.com/api/");
//});
builder.Services.AddHttpClient<IHeroService, HeroService>(client =>
{
    client.BaseAddress = new Uri("https://superhero-search.p.rapidapi.com/api/");
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
