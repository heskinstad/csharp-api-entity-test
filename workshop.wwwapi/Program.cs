using workshop.wwwapi.Data;
using workshop.wwwapi.Endpoints;
using workshop.wwwapi.Models;
using workshop.wwwapi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<IRepository<Patient>, Repository<Patient>>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigurePatientEndpoint();
app.Run();

public partial class Program { } // needed for testing - please ignore