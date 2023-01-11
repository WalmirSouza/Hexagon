using Hexagon.Datas.Data;
using Hexagon.Repositories;
using Hexagon.Repositories.Interfaces;
using Hexagon.Services;
using Hexagon.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<HexagonAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HexagonAPIContext") ?? throw new InvalidOperationException("Connection string 'HexagonAPIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient(typeof(IService<>), typeof(ServiceBase<>));
builder.Services.AddTransient(typeof(IRepository<>), typeof(RepositoryBase<>));

builder.Services.AddTransient<IPessoaService, PessoaService>();
builder.Services.AddTransient<PessoaRepository>();

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
