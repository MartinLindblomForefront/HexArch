
namespace HexArch.Infrastructure.CommandLine;

public class CliReader(IEnumerable<ICommandLineHandler> CommandLineHandlers) : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken) => Task.Run(() =>
    {
        Thread.Sleep(500);
        while (!stoppingToken.IsCancellationRequested)
        {
            Console.WriteLine();
            Console.Write("Command: ");
            var input = Console.ReadLine();
            if (input != null)
            {
                var result = CommandLineHandlers
                    .FirstOrDefault(h => h.Handles(input))
                    ?.Handle(input);

                Console.WriteLine(result ?? "No handler found!");
            }
        }
    }, stoppingToken);
}