using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using WebApplication2.Service.Todo;
using NetCore.AutoRegisterDi;
using WebApplication2.Entities;
using WebApplication2.UnitOfWork;
using WebApplication2.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<TodoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("todo")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

builder.Services.AddScoped(typeof(IUnitOfWork<>),typeof(UnitOfWork<>));
builder.Services.AddScoped(typeof(IMainRepository<>), typeof(MainRepository<>));
builder.Services.RegisterAssemblyPublicNonGenericClasses().Where(c => c.Name.EndsWith("Services")).AsPublicImplementedInterfaces(ServiceLifetime.Scoped);
//builder.Services.AddTransient<ITodoServices,TodoServices>();


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
