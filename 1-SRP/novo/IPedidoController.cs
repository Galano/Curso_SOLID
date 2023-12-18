interface IPedidoController
{
    IEnviarEmail EnviaEmail { get; set; }
    IPedidoRepository PedidoRepository { get; set; }
    void IncluirPedido(string from, string to);
    void DeletaPedido();
}
