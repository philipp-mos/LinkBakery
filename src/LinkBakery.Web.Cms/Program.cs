using LinkBakery.Application;
using LinkBakery.Persistence;
using LinkBakery.Web.Cms.Services;
using LinkBakery.Web.Cms.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;


services.AddApplicationServices();
services.AddPersistenceServices(builder.Configuration);


builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


builder.Services.AddScoped<ITrackingLinkService, TrackingLinkService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
