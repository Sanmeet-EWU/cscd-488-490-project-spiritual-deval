using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MimeKit;

public class GmailServiceHelper
{
    private static readonly string[] Scopes = { GmailService.Scope.GmailSend };
    private static readonly string ApplicationName = "Spiritual Temple App";

    public async Task SendEmailAsync(string to, string subject, string body)
    {
        UserCredential credential;

        using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
        {
            credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                Scopes,
                "user",
                CancellationToken.None,
                new FileDataStore("GmailAPI", true));
        }

        // Create the Gmail API service
        var service = new GmailService(new BaseClientService.Initializer
        {
            HttpClientInitializer = credential,
            ApplicationName = ApplicationName,
        });

        // Create the email message
        var email = CreateEmail(to, "spiritual.temple@gmail.com", subject, body);
        var request = service.Users.Messages.Send(email, "me");
        await request.ExecuteAsync();
    }

    private Message CreateEmail(string to, string from, string subject, string body)
    {
        var email = new System.Net.Mail.MailMessage
        {
            From = new System.Net.Mail.MailAddress(from),
            Subject = subject,
            Body = body,
            IsBodyHtml = true
        };
        email.To.Add(to);

        // Convert the MailMessage to a MimeMessage
        var mimeMessage = MimeMessage.CreateFromMailMessage(email);

        // Convert the MimeMessage to a base64url-encoded string
        var rawMessage = Base64UrlEncode(mimeMessage.ToString());

        return new Message
        {
            Raw = rawMessage
        };
    }

    private static string Base64UrlEncode(string input)
    {
        var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
        return System.Convert.ToBase64String(inputBytes)
            .Replace('+', '-')
            .Replace('/', '_')
            .Replace("=", "");
    }
}