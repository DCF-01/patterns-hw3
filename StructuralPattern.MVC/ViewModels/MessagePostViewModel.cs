using StructuralPattern.Services.Models;

namespace StructuralPattern.MVC.ViewModels;

public class MessagePostViewModel
{
    public string Recipients { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string Senders { get; set; }
    private string _style;
    public string Style
    {
        get => _style;
        set => _style = "{ " + value + " }";
    }

    public Message ToMessageModel => new Message(Recipients, Title, Body, Senders, Style);
}