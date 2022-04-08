using LinkBakery.Core.Data;
using LinkBakery.Core.Repositories;
using LinkBakery.Core.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        assembly => assembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
    );
});


builder.Services.AddScoped<ITrackingLinkRepository, TrackingLinkRepository>();
    


var app = builder.Build();


app.MapGet("/", () => { });

app.MapGet("/all", (ITrackingLinkRepository trackingLinkRepository) 
    => trackingLinkRepository.GetAll());


app.Run();
