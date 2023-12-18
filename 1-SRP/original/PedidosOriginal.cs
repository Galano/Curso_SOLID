using System.Net.Mail;

class PedidosOriginal
{
    public long Quantidade { get; set; }
    public DateTime Data { get; set; }
    public void Gerar(string from, string to)
    {
        try
        {
            Console.WriteLine("Pedido incluido!");
            Quantidade++;
            MailMessage mailMessage = new MailMessage(from, to, "Novo Pedido", $"Pedidos: {Quantidade}");
            // classe de email dentro da classe pedido???
            this.EnviaEmailPedido(mailMessage);
        }
        catch (Exception ex)
        {
            // Gerando log aqui???
            Console.WriteLine(ex.Message.ToString());
        }
    }
    public void Remover()
    {
        try
        {
            if (Quantidade <= 0)
                throw new Exception($"Não existem pedidos");

            Quantidade--;
            Console.WriteLine("Pedido deletado!");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
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
            Console.WriteLine(ex.Message.ToString());
        }
    }
}
