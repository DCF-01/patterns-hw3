using Microsoft.AspNetCore.Mvc;
using StructuralPattern.MVC.ViewModels;
using StructuralPattern.Services.Commands;
using StructuralPattern.Services.Interfaces;

namespace StructuralPattern.MVC.Controllers;

public class MessageController : Controller
{
    private readonly ILogger<MessageController> _logger;
    private readonly IMessageService _messageService;
    private readonly IEmailClient _emailClient;

    public MessageController(ILogger<MessageController> logger, IMessageService messageService, IEmailClient emailClient)
    {
        _logger = logger;
        _messageService = messageService;
        _emailClient = emailClient;
    }

    [HttpPost]
    public IActionResult Send([FromForm] MessagePostViewModel messagePostViewModel)
    {
        var messageModel = messagePostViewModel.ToMessageModel;
        var command = new MessageCommand(messageModel, _emailClient);
        var result = _messageService.Send(command);

        if (result)
        {
            return RedirectToAction("Index", "Home", new ResultViewModel{ Message = "Generated successfully.", PathToMessage = "html/message.html"});
        }

        return RedirectToAction("Index", "Home", new ResultViewModel{ Message = "There was an error.", PathToMessage = string.Empty});
    }
}