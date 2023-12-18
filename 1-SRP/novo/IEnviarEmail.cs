public interface IEnviarEmail
{
    bool Enviar(string from, string to, string subject, string body);
}