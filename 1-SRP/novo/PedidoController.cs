class PedidoController : IPedidoController
{
    public IEnviarEmail EnviaEmail { get; set; }
    public IPedidoRepository PedidoRepository { get; set; }
    
    public PedidoController()
    {
        PedidoRepository = new PedidoRepository();
        EnviaEmail = new EnviarEmail();
    }
    public void IncluirPedido(string from, string to)
    {
        PedidoRepository.Incluir();
        EnviaEmail.Enviar(from,to, "Novo Pedido", 
            $"Pedidos: {PedidoRepository.Quantidade}"  );
    }
    public void DeletaPedido()
    {
        PedidoRepository.Deletar();
    }
}
