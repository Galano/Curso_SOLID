using System.Net.Mail;

class PedidoSRPOriginal
{
    public long Quantidade { get; set; }
    public DateTime Data { get; set; }
    public void IncluirPedido()
    {
        try
        {
            Console.WriteLine("Pedido incluido!");

            MailMessage mailMessage = new MailMessage("EMailFrom@gmail.com", 
                "EMailTo@gmail.com", "EMailSubject", "EMailBody");

            // classe de email dentro da classe pedido???
            this.EnviaEmailPedido(mailMessage);
        }
        catch (Exception ex)
        {
            // Gerando log aqui???
            Console.WriteLine(ex.ToString());
        }
    }
    public void DeletaPedido()
    {
        try
        {
            Console.WriteLine("Pedido deletado!");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public void EnviaEmailPedido(MailMessage mailMessage)
    {
        try
        {
            Console.WriteLine("E-mail enviado!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
