// Configuração do Builder

using DemoRider;

var builder = WebApplication.CreateBuilder(args);

// Configuração do Pipeline

// Middlewares
   // A ordem dos Middlewares importa
// Services

// Configuração da App

var app = builder.Build();

app.UseMiddleware<LogTimeMiddleware>();

// Configuração de Comportamentos da App

app.MapGet("/", () => "Hello World!");
// pattern = caminho, path da pagina na url, o endpoint
// mapeamento de rotas
app.MapGet("/teste", () =>
{
   Thread.Sleep(1500);
   return "Teste time 1.5 segundos";
});

app.Run();