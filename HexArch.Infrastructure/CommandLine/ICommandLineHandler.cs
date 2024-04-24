namespace HexArch.Infrastructure.CommandLine;

public interface ICommandLineHandler
{
    public bool Handles(string command);
    public string Handle(string command);
}