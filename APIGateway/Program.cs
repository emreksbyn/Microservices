using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://*:1000");

builder.Configuration.AddJsonFile(Path.Combine("ocelot.json"));
builder.Services.AddControllers();

builder.Services.AddOcelot(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
}

app.UseRouting();
app.UseAuthorization();
app.MapControllers();

await app.UseOcelot();

app.Run();