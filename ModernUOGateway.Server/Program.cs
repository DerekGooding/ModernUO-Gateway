namespace ModernUOGateway.Server;

public class Program
{
    public static Task Main(string[] args)
    {
        return WebApplicationServer.BuildWebApplicationServer(args).RunAsync();
    }
}