class PedidoRepository : IPedidoRepository
{
    public long Quantidade { get; private set; }
    public DateTime Data { get; set; }

    public PedidoRepository()
    {
        Quantidade = 0;
        Data = DateTime.Now;
    }

    public void Incluir() 
    {
        try
        {
            RegistraLog.Info("Pedido incluido ");
            Quantidade++;
        }
        catch (Exception ex)
        {
            RegistraLog.Erro(ex);
        }
    }
    public void Deletar()
    {
        try
        {
            if (Quantidade <= 0)
                throw new Exception($"Não existem pedidos" );

            Quantidade--;
            RegistraLog.Info($"Pedido deletado");

        }
        catch (Exception ex)
        {
            RegistraLog.Erro(ex);
        }
    }
}
