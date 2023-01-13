using System.Net.Mail;
using StructuralPattern.Services.Interfaces;

namespace StructuralPattern.Services.Models;

public class Message : IMessage
{
    public string[] Recipients { get; }
    public string Title { get; }
    public string Body { get; }
    public string[] Senders { get; }
    public string Style { get; }

    public Message(string recipients, string title, string body, string senders, string style)
    {
        Title = title;
        Body = body;
        Senders = GetStringArray(senders);
        Style = style;
        Recipients = GetStringArray(recipients);
    }

    private string[] GetStringArray(string csvString)
    {
        string[] stringArr = new string[0];

        try
        {
            stringArr = csvString.Replace(" ", "").Split(',');
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to convert comma separated string to array {ex.Message}");
        }

        return stringArr;
    }
}