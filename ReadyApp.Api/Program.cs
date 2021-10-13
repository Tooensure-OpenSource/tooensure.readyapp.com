using Microsoft.EntityFrameworkCore;
using ReadyApp.Api.Repositories;
using ReadyApp.Data;
using ReadyApp.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(setupAction =>
{
    setupAction.ReturnHttpNotAcceptable = true;
    //setupAction.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
}).AddXmlDataContractSerializerFormatters();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IBusinessRepository, BusinessesRepository>();
builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();

builder.Services.AddDbContext<DataContext>(opt =>
        opt.UseSqlServer(builder.Configuration.GetConnectionString("ReadyAppDb"))
        .EnableSensitiveDataLogging()
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
