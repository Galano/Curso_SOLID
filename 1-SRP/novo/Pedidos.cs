public class Pedidos : IPedidos
{
    private readonly IPedidoRepository _pedidoRepository;
    private readonly IEnviarEmail _enviarEmail;

    public Pedidos(IPedidoRepository pedidoRepository, IEnviarEmail enviarEmail)
    {
        _pedidoRepository = pedidoRepository;
        _enviarEmail = enviarEmail;
    }
    public bool Gerar(string from, string to)
    {
        _pedidoRepository.Incluir(from, to);
        _enviarEmail.Enviar(from,to, "Novo Pedido", $"Pedidos: {_pedidoRepository.Quantidade}"  );
        return true;
    }
    public void Remover()
    {
        _pedidoRepository.Deletar();
    }

}
