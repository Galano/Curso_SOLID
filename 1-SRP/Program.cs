Console.WriteLine("[start] [" + DateTime.Now+"]");


var enviarEmail = new EnviarEmail();
var pedidoRepository = new PedidoRepository();
Pedidos pedidoController = new Pedidos(pedidoRepository,enviarEmail);
//PedidoControllerOriginal pedido = new PedidoControllerOriginal();

pedidoController.Gerar("EMailFrom@gmail.com", "EMailTo@gmail.com");
pedidoController.Remover();
pedidoController.Gerar("xxx.com", "xxx.com");

Console.WriteLine("[end] [" + DateTime.Now + "]");



