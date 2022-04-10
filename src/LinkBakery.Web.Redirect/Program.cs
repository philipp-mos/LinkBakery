using System.Net;
using LinkBakery.Application;
using LinkBakery.Application.Features.TrackingLinks.Queries.GetTrackingLinkRedirectUrl;
using LinkBakery.Persistence;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;


services.AddApplicationServices();
services.AddPersistenceServices(builder.Configuration);


var app = builder.Build();

var redirectTrackingKey = async (string key, IMediator mediator, HttpContext  httpContext) =>
{
    var trackingLinkRedirectUrlVm = await mediator.Send(new GetTrackingLinkRedirectUrlQuery() { Key = key });


    if (trackingLinkRedirectUrlVm == null || string.IsNullOrEmpty(trackingLinkRedirectUrlVm.TargetUrl))
    {
        httpContext.Response.StatusCode = (int) HttpStatusCode.NotFound;
        return;
    }

    httpContext.Response.StatusCode = (int) HttpStatusCode.Redirect;
    httpContext.Response.Redirect(trackingLinkRedirectUrlVm.TargetUrl);
};

app.MapGet("/{key}", redirectTrackingKey);


app.Run();
