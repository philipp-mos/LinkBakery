using LinkBakery.Application;
using LinkBakery.Persistence;
using LinkBakery.Web.Redirect.Services;
using LinkBakery.Web.Redirect.Services.Interfaces;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;


services.AddApplicationServices();
services.AddPersistenceServices(builder.Configuration);


// builder.Services.AddScoped<ITrackingLinkService, TrackingLinkService>();


var app = builder.Build();


/*

var redirectTrackingKey = (string key, ITrackingLinkService trackingLinkService, HttpContext httpContext) =>
{
    var targetUrl = trackingLinkService.GetLinkAndTrackCall(key, httpContext.Request.QueryString.Value);

    if (string.IsNullOrEmpty(targetUrl))
    {
        httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
        return;
    }

    httpContext.Response.StatusCode = (int)HttpStatusCode.Redirect;
    httpContext.Response.Redirect(targetUrl);
};

*/

var redirectTrackingKey = (string key) =>
{
    return $"Hallo { key }";
};

app.MapGet("/{key}", redirectTrackingKey);


app.Run();
