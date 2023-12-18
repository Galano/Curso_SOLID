Console.WriteLine("[start] [" + DateTime.Now+"]");


PedidoController pedidoController = new PedidoController();
//PedidoControllerOriginal pedido = new PedidoControllerOriginal();

pedidoController.IncluirPedido("EMailFrom@gmail.com", "EMailTo@gmail.com");
pedidoController.DeletaPedido();
pedidoController.DeletaPedido();
pedidoController.IncluirPedido("xxx.com", "xxx.com");

Console.WriteLine("[end] [" + DateTime.Now + "]");



