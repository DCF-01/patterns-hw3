using StructuralPattern.Services.Interfaces;

namespace StructuralPattern.Services;

public class MessageService : IMessageService
{
    public bool Send(ICommand command)
    {
        try
        {
            command.Execute();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Failed to execute command {e.Message}");
        }

        return false;
    }
}