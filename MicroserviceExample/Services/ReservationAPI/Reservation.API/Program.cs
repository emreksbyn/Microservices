using Reservation.API.Infrastructure.AbstractServices;
using Reservation.API.Services.ConcreteServices;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://*:7001");

builder.Services.AddControllers();
builder.Services.AddScoped<IReservationService, ReservationService>();


builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();