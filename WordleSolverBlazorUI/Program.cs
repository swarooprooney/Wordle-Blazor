using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using WordleSolverBlazorUI.Data;
using WordleSolverBlazorUI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient("WordleClient",
    client => client.BaseAddress = new Uri("http://wordlesolver-azure.azurewebsites.net/api/v1/Wordle/"));
builder.Services.AddSingleton<IWordleService, WordleService>();
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
// using Microsoft.AspNetCore.Components.Web;
// using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
// using WordleSolverBlazorUI;
// using WordleSolverBlazorUI.Services;

// var builder = WebAssemblyHostBuilder.CreateDefault(args);
// builder.RootComponents.Add<App>("#app");
// builder.RootComponents.Add<HeadOutlet>("head::after");

// //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// //builder.Services.AddHttpClient<IWordleService, WordleService>(client => client.BaseAddress = new Uri("http://wordlesolver-azure.azurewebsites.net/api/v1/Wordle/"));

// builder.Services.AddHttpClient("WordleClient",
//     client => client.BaseAddress = new Uri("http://wordlesolver-azure.azurewebsites.net/api/v1/Wordle/"));
// builder.Services.AddSingleton<IWordleService, WordleService>();

// await builder.Build().RunAsync();