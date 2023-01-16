using System.Text;
using StructuralPattern.Services.Helpers;
using StructuralPattern.Services.Interfaces;
using StructuralPattern.Services.Models;
using StructuralPattern.Services.Template;

namespace StructuralPattern.Services.Commands;

public class MessageCommand : ICommand
{
    private readonly IMessage _message;
    private readonly IEmailClient _emailClient;

    public MessageCommand(IMessage message, IEmailClient emailClient)
    {
        _message = message;
        _emailClient = emailClient;
    }

    public void Execute()
    {
        string htmlDoc = string.Format(HtmlTemplate.Html, _message.Title, _message.Body, string.Join(", ", _message.Senders), _message.Style);

        foreach (var recipient in _message.Recipients)
        {
            if (!EmailHelpers.ValidateEmailAddress(recipient))
            {
                Console.WriteLine($"Recipient address {recipient} was invalid, skipping.");
                continue;
            }

            _emailClient.Send(recipient, _message.Senders, _message.Title, htmlDoc);
        }

        SaveInRootDir(htmlDoc);
    }

    private void SaveInRootDir(string htmlString)
    {
        var path = Directory.GetCurrentDirectory() + "\\wwwroot\\html\\message.html";
        Console.WriteLine($"writing to {path}");
        using var sw = new StreamWriter(path, false);

        sw.WriteLine(htmlString);
    }
}