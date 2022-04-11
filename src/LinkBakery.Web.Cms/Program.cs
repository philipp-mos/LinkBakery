using LinkBakery.Application;
using LinkBakery.Persistence;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;


services.AddApplicationServices();
services.AddPersistenceServices(builder.Configuration);


builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


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
