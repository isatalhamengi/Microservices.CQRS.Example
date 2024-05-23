using Microservices.CQRS.Example.Manual_CQRS.Handlers.CommandHandlers;
using Microservices.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers;
using Microservices.CQRS.Example.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

#region ManuelCQRS
builder.Services.AddSingleton<CreateProductCommandHandler>()
    .AddSingleton<DeleteProductCommandHandler>()
    .AddSingleton<GetAllProductQueryHandler>()
    .AddSingleton<GetByIdProductQueryHandler>();
#endregion

#region MediatR CQRS
builder.Services.AddMediatR(conf => conf.RegisterServicesFromAssembly(typeof(ApplicationDbContext).Assembly));
#endregion 

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
