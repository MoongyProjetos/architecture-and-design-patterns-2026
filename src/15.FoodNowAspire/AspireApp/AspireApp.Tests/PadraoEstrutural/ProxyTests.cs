namespace AspireApp.Tests.PadraoEstrutural.Proxy;

using AspireApp.Model.PadraoEstrutural.Proxy;
using Moq;

public class ProxyTests
{
    [Fact]
    public void Mostrar_UsuarioNaoAdmin_DeveNegarAcesso()
    {
        // Arrange
        var mock = new Mock<IPedidoDetalhado>();
        var proxy = new ProxyPedido(mock.Object, "Outro");

        // Act
        var resultado = proxy.Mostrar();

        // Assert
        Assert.Equal("Acesso negado", resultado);
        mock.Verify(p => p.Mostrar(), Times.Never);
    }

    [Fact]
    public void Mostrar_UsuarioAdmin_DevePermitirAcesso()
    {
        // Arrange
        var mock = new Mock<IPedidoDetalhado>();
        mock.Setup(p => p.Mostrar()).Returns("Detalhes do pedido 1234");

        var proxy = new ProxyPedido(mock.Object, "admin");

        // Act
        var resultado = proxy.Mostrar();

        // Assert
        Assert.Equal("Detalhes do pedido 1234", resultado);
        mock.Verify(p => p.Mostrar(), Times.Once);
    }

    [Fact]
    public void Mostrar_AdminEDefault_DevemTerComportamentosDiferentes()
    {
        // Arrange
        var mock = new Mock<IPedidoDetalhado>();
        mock.Setup(p => p.Mostrar()).Returns("Detalhes");

        var admin = new ProxyPedido(mock.Object, "admin");
        var user = new ProxyPedido(mock.Object, "Outro");

        // Act
        var resultadoAdmin = admin.Mostrar();
        var resultadoUser = user.Mostrar();

        // Assert
        Assert.NotEqual(resultadoAdmin, resultadoUser);
    }
}