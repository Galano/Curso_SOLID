using System.Net.Mail;

interface IEnviarEmail
{
    bool Enviar(string from, string to, string subject, string body);
}