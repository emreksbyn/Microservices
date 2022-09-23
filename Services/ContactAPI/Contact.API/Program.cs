using Contact.API.Infrastructure.AbstractServices;
using Contact.API.Services.ConcreteServices;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://*:7000");

builder.Services.AddControllers();
builder.Services.AddScoped<IContactService, ContactService>();


builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();