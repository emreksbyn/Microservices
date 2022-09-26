using Contact.API.Infrastructure.AbstractServices;
using Contact.API.Services.ConcreteServices;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://*:7000");

builder.Services.AddControllers();

builder.Services.AddScoped<IContactService, ContactService>();


#region Dependecy Injection
// Her request icin sadece bir tane instance uretilir.
//builder.Services.AddScoped<IContactService, ContactService>();

// Ihtiyac duyuldugunda bir kere uretilir uygulama bellekten silinene kadar bu nesne kullanilir.
//builder.Services.AddSingleton<IContactService, ContactService>();

// Her request icinde de her lazim oldugunda yeniden uretilip o kullanilir. 
//builder.Services.AddTransient<IContactService, ContactService>(); 
#endregion


builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();