var builder = WebApplication.CreateBuilder(args);

var socketPath = Path.Combine(Path.GetTempPath(), "nosso.sock");

if (File.Exists(socketPath))
    File.Delete(socketPath);

builder.WebHost.ConfigureKestrel(options => options.ListenUnixSocket(socketPath));

var app = builder.Build();

app.MapGet("/", () => "Passei por aqui";

app.Run();
