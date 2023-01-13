using StructuralPattern.Services.Interfaces;

namespace StructuralPattern.Services;

public class EmailClient : IEmailClient
{
    public void Send(string mailTo, string[] ccList, string title, string mailBody)
    {
        Console.WriteLine($"Send mail to {mailTo}");
    }
}