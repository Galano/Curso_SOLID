
Console.WriteLine("[START] [" + DateTime.Now+"]");

// PedidoSRPOriginal pedido = new PedidoSRPOriginal();
PedidoSRP pedido = new PedidoSRP();

pedido.IncluirPedido();
pedido.DeletaPedido();

Console.WriteLine("[END] [" + DateTime.Now + "]");
