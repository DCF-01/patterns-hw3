namespace StructuralPattern.Services.Interfaces;

public interface IMessage
{
    public string[] Recipients { get; }
    public string Title { get; }
    public string Body { get; }
    public string[] Senders { get; }
    public string Style { get; }
}