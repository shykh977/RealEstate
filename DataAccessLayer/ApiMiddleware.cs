namespace PropertyBackend.DataAccessLayer
{
    public class ApiMiddleware
    {
        private readonly RequestDelegate _next;
        private
        const string APIKEY = "PtApiKey";
        public ApiMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {


            var remoteIpAddress = context.Response.HttpContext.Connection.RemoteIpAddress;

            if (!context.Request.Headers.TryGetValue(APIKEY, out
                    var extractedApiKey))
            {
                context.Response.StatusCode = 808;
               
                await context.Response.WriteAsync("Unauthorized client");
                return;
            }
            var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();
            var apiKey = appSettings.GetValue<string>(APIKEY);
            if (!apiKey.Equals(extractedApiKey))
            {
                context.Response.StatusCode = 808;
                await context.Response.WriteAsync("Unauthorized client");
                return;
            }
            await _next(context);
        }
    }
}
