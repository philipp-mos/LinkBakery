using LinkBakery.Core.Data;
using LinkBakery.Core.Repositories;
using LinkBakery.Core.Repositories.Interfaces;
using LinkBakery.Web.Cms.Services;
using LinkBakery.Web.Cms.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        assembly => assembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
    );
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddScoped<ITrackingLinkRepository, TrackingLinkRepository>();

builder.Services.AddScoped<ITrackingLinkService, TrackingLinkService>();


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
