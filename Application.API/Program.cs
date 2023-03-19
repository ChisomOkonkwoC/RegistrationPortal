using Application.API.Configuration;
using Application.Infastructure.Data;
using Application.Infrastructure.Seeder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterDbContext(builder.Configuration);
builder.Services.AddDependencyInjection(builder.Configuration);
builder.Services.AddSwaggerConfiguration();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbcontext = services.GetRequiredService<AppDbContext>();
    Seeder.Seed(dbcontext).Wait();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
