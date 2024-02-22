using banhang.Payloads.Converters;
using banhang.Payloads.DataResponses;
using banhang.Payloads.Responses;
using banhang.Services.Implements;
using banhang.Services.Interfaces;
using WA_1_1_api.Entites;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IHoaDonServices, HoaDonServices>();
builder.Services.AddSingleton<HoaDonConverter>();
builder.Services.AddSingleton<ResponseObject<DataResponseHoaDon>>();

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
