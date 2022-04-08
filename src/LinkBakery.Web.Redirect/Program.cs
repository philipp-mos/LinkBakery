using LinkBakery.Core.Data;
using LinkBakery.Core.Repositories;
using LinkBakery.Core.Repositories.Interfaces;
using LinkBakery.Web.Redirect.Services;
using LinkBakery.Web.Redirect.Services.Interfaces;
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




var app = builder.Build();


app.MapGet("/", () => { });

app.MapGet("/all", (ITrackingLinkService trackingLinkService) 
    => trackingLinkService.GetAll());


app.Run();
