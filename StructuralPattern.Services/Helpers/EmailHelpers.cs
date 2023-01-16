using System.Net.Mail;

namespace StructuralPattern.Services.Helpers;

public static class EmailHelpers
{
    public static bool ValidateEmailAddress(string email)
    {
        try
        {
            new MailAddress(email);
        }
        catch (Exception e)
        {
            return false;
        }

        return true;
    }
}