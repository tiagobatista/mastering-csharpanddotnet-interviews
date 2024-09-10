public class CustomMiddleware
{
    private readonly RequestDelegate _next;

    public CustomMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("Request processing");
        await _next(context);
        Console.WriteLine("Response processing");
    }
}

// adding middleware to the pipeline in startup.cs or program
public void Configure(IApplicateBuilder app)
{
    app.UseMiddleware<CustomMiddleware>();
    app.Run(async context => await context.Response.WriteAsync("Hello world"));
}

public interface IMessageService
{
    string GetMessage();
}

public class MessageService : IMessageService
{
    public string GetMessage() => "Hello from the service";
}

public class HomeController : Controller
{
    private readonly IMessageService _messageService;

    public HomeController(IMessageServiceService messageService)
    {
        _messageService = messageService;
    }

    public IActionResult Index()
    {
        var message = _messageService.GetMessage();
        return Content(message);
    }
}

public void ConfigureServices(IServiceCollection services)
(
    services.AddTransient<IMessageService, MessageService>();
)