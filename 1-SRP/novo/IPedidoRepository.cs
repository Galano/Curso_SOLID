using System.Net.Mail;

public interface IPedidoRepository
{
    public long Quantidade { get; }
    public DateTime Data { get; set; }
    public bool Incluir(string from, string to);
    public void Deletar();
}