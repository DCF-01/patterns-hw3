using Microsoft.AspNetCore.Mvc;

namespace StructuralPattern.MVC.Controllers;

public class MessageController : ControllerBase
{
    private readonly ILogger<MessageController> _logger;

    public MessageController(ILogger<MessageController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Send([FromForm])
    {
        
    }
}