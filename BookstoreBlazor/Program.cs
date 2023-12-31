using BookstoreBlazor;
using BookstoreBlazor.Services;
using BookstoreDatabase.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7195") });
builder.Services.AddScoped<CartService>();

await builder.Build().RunAsync();