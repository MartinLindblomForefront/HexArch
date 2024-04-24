using HexArch.Application.Services;

namespace HexArch.Infrastructure.CommandLine;

public class CreateAuthorCommandLineHandler(ICreateAuthorService CreateAuthorService) : ICommandLineHandler
{
    public string Handle(string command)
    {
        try
        {
            var arguments = command["author create".Length..].Trim().Split();
            var author = CreateAuthorService.Create(arguments[0], arguments[1]);

            return author.ToString();
        }
        catch (Exception ex)
        {
            return "Failed to create author! " + ex.Message;
        }
    }

    public bool Handles(string command) => command.StartsWith("author create");
}