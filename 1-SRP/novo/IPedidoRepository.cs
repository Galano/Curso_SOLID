using System.Net.Mail;

interface IPedidoRepository
{
    public long Quantidade { get; }
    public DateTime Data { get; set; }
    public void Incluir();
    public void Deletar();
}