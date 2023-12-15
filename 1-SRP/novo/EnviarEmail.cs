using System.Net.Mail;

class EnviarEmail : IEnviarEmail
{
    public MailMessage _mailMessage { get; set; }
    public bool Enviar(string from, string to, string subject, string body)
    {
        // throw new Exception("aranha!");
        _mailMessage = new MailMessage(from, to, subject, body);
        return true;
    }
}