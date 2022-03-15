using AutoMapper;
using Bankos.DataAccessLayer.Models;
using Bankos.GenericRepository.Repo;
using Bankos.Services.BusinessLogic.BasicServices.UserServices;
using Bankos.Services.Utilities;
using Bankos.UnitofWork.UOF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BankosContext>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUnitofWork, UnitofWork>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddAutoMapper(typeof(Program));

var mappingConfigs = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

var mapper = mappingConfigs.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
