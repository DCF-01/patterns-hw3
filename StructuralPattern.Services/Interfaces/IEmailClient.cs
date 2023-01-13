namespace StructuralPattern.Services.Interfaces;

public interface IEmailClient
{
    void Send(string mailTo, string[] ccList, string title, string mailBody);
}