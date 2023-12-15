# SRP - Single Responsability Principle

- Cada classe deve ter apenas uma responsabilidade a ser cumprida;

Vantagens:

- unica responsabilidade
- classes menores
- manter
- entender
- testar

## Original

Uma classe unica sem um controle apropriado dos logs.

`PedidoSRPOriginal pedido = new PedidoSRPOriginal();`

[<img src="../img/srp-original.png" width="600" />](./Original/PedidoSRPOriginal.cs)

## Novo

A classe de pedido cuida apenas das tratativas do pedidos. Existe uma nova classe para cuidar dos _Logs_ e uma para _Envio de Email_.

`PedidoSRP pedido = new PedidoSRP();`

[<img src="../img/srp-novo.png" width="600" />](./Novo/PedidoSRP.cs)

---

[Voltar](../readme.md)
