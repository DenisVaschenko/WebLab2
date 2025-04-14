var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(7161, listenOptions =>
    {
        listenOptions.UseHttps("Resources/localhost.p12", "changeit");
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
