using Metiador.Service.Contracts.Service; 
using Metiador.Service.Contracts.Interface;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Agora o ASP.NET vai encontrar tanto a Interface quanto a Classe Concreta!
builder.Services.AddScoped<IPedidoMetiador, PedidoMetiador>();

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