using System.Net.Mail;
class EnviarEmail : IEnviarEmail
{
    private MailMessage? _MailMessage;
    public bool Enviar(string from, string to, string subject, string body)
    {
        try
        {
            _MailMessage = new MailMessage(from, to, subject, body);
            RegistraLog.Info($"E-mail enviado. / Body: {body}");
            return true;
        }
        catch (Exception ex)
        {
            RegistraLog.Erro(ex);
        }
        return false;
    }
}