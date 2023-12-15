using System.Net.Mail;

interface IEnviarEmail
{
    public MailMessage _mailMessage { get; set; }
    bool Enviar(string from, string to, string subject, string body);
}