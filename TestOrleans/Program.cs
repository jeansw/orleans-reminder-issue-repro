var builder = WebApplication.CreateBuilder(args);

builder.Host.UseOrleans((_, siloBuilder) =>
{
    siloBuilder
        .UseLocalhostClustering()
        .AddMemoryGrainStorageAsDefault()
        .UseInMemoryReminderService();
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();