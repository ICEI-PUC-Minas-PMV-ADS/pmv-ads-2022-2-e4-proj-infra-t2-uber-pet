using api_servico_motorista.Models;
using api_servico_motorista.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<MotoristaDatabaseSettings>(
    builder.Configuration.GetSection("MotoristaDatabase"));

builder.Services.AddSingleton<MotoristasService>();
builder.Services.AddSingleton<VeiculosService>();
builder.Services.AddSingleton<ViagensService>();
builder.Services.AddSingleton<AvaliacoesService>();

builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Motorista", Version = "v1" } );
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
