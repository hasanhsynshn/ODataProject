using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using StartupAPIProject.Infrastructure.Context;
using StartupAPIProject.Services.Abstract;
using StartupAPIProject.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<StartupDbContext>(options =>
{
    // Configure your DbContext options here
    options.UseSqlServer(builder.Configuration.GetConnectionString("StartupDatabase")).EnableSensitiveDataLogging();
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});
builder.Services.AddControllers(x => { x.EnableEndpointRouting = false; })
    .AddOData(x =>
    {
        x.EnableQueryFeatures();
    });
builder.Services.AddScoped<IFilterService, FilterService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseCors("AllowLocalhost");

app.UseAuthorization();

app.MapControllers();

app.Run();
