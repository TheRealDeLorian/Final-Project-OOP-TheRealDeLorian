using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using scheduleUI.Data;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjAzMzcwQDMxMzkyZTM0MmUzMEhGa1RtTW1yb016VnpkNGxCUFRVM05UMzdzdTczY3k5dmRXTVVXNllJZW89");
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });

var app = builder.Build();
//Register Syncfusion license

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


