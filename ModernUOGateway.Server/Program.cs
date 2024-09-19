namespace ModernUOGateway.Server;

public static class Program
{
    public static Task Main(string[] args) => WebApplicationServer.BuildWebApplicationServer(args).RunAsync();
}