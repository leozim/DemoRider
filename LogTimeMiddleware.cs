using System.Diagnostics;
using Serilog;

namespace DemoRider
{
    public class LogTimeMiddleware
    {
        private readonly RequestDelegate _next;

        public LogTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Faz algo antes
            var sw = Stopwatch.StartNew();
            
            // Chama o próximo middleware no pipeline
            await _next(context);
            
            sw.Stop();

            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Log.Information($"A execução demorou {sw.Elapsed.TotalMilliseconds}ms ({sw.Elapsed.TotalSeconds}s)");

            // Faz algo depois
        }
    }
}