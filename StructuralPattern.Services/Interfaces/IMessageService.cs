namespace StructuralPattern.Services.Interfaces;

public interface IMessageService
{
    bool Send(ICommand command);
}