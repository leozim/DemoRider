namespace DemoRider
{
    public class TemplateMiddleware
    {
        private readonly RequestDelegate _next;

        public TemplateMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Faz algo antes
            
            // Chama o próximo middleware no pipeline
            await _next(context);
            
            // Faz algo depois
        }
    }
}
