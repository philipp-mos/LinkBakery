using LinkBakery.Core.Data;
using LinkBakery.Core.Repositories;
using LinkBakery.Core.Repositories.Interfaces;
using LinkBakery.Web.Redirect.Services;
using LinkBakery.Web.Redirect.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Net;

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


app.MapGet("/redirect/{key}", (string key, ITrackingLinkService trackingLinkService, HttpContext httpContext) =>
{
    var targetUrl = trackingLinkService.GetLink(key);

    if (string.IsNullOrEmpty(targetUrl))
    {
        httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
        return;
    }

    httpContext.Response.StatusCode = (int) HttpStatusCode.Redirect;
    httpContext.Response.Redirect(targetUrl);
});


app.Run();
