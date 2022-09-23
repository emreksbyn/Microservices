using Contact.API.Infrastructure.AbstractServices;
using Contact.API.Services.ConcreteServices;

var builder = WebApplication.CreateBuilder(args);

//builder.WebHost.UseUrls("http://*:9000");

builder.Services.AddControllers();
builder.Services.AddScoped<IContactService, ContactService>();


builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
