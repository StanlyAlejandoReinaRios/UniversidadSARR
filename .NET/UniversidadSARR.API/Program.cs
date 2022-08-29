using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Universidad.Models;
using UniversidadSARR.Business;
using UniversidadSARR.Business.Abstract;
using UniversidadSARR.Business.Services;

var myAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:4200")
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                      });
});

builder.Services.AddScoped<IUniversidadAbstract, UniversidadServices>();
builder.Services.AddScoped<ITipoUsuarioAbstract, TipoUsuariosServices>();

//var MapperCongif = new MapperConfiguration(m =>
//{
//    m.AddProfile(new MappingProfile());
//});

//IMapper mapper = MapperCongif.CreateMapper();

//713 valle 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//builder.Services.AddSingleton(mapper);
//builder.Services.AddMvc();
app.UseHttpsRedirection();

app.UseCors(myAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
