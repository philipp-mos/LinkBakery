using LinkBakery.Core.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        assembly => assembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
    );
});
    


var app = builder.Build();

app.MapGet("/", () => { });

app.Run();
