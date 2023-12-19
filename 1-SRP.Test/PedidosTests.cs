using Moq;

public class PedidoControllerTestes
{
    private Mock<IPedidoRepository> _pedidoRepositoryMock;
    private Mock<IEnviarEmail> _enviarEmailMock;
    private Pedidos _pedidos;

    [Fact]
    public void IncluirComSucesso()
    {
        _pedidoRepositoryMock = new Mock<IPedidoRepository>();
        _enviarEmailMock = new Mock<IEnviarEmail>();
        _pedidoRepositoryMock.Setup(e => e.Deletar());
        _pedidos = new Pedidos(_pedidoRepositoryMock.Object, _enviarEmailMock.Object);

        string from = "test@test.com";
        string to = "test2@test.com";
        Assert.True(_pedidos.Gerar(from, to));
        _pedidoRepositoryMock.Verify(pr => pr.Incluir(from, to), Times.Once);
        _enviarEmailMock.Verify(ee => ee.Enviar(from, to, "Novo Pedido", $"Pedidos: 0"), Times.Once);
    }

    [Fact]
    public void RemoverComSucesso()
    {
        _pedidos.Remover();
        _pedidoRepositoryMock.Verify(pr => pr.Deletar(), Times.Once);
    }

}
