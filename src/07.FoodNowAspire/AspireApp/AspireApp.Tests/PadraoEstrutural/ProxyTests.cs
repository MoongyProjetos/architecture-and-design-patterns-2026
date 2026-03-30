namespace AspireApp.Tests.PadraoEstrutural.Proxy;

using AspireApp.Model.PadraoEstrutural.Proxy;
public class ProxyTests
{
    [Fact]
    public void ExemploUsoProxySemAcesso()
    {
        // Given        
        var pedidoNaoAdmin = new ProxyPedido("1234", "Outro");
        pedidoNaoAdmin.Mostrar(); //Como não é admin, não entra no Pedido Real
    }

    [Fact]
    public void ExemploUsoProxyComAcesso()
    {
        // Given        
        var pedidoAdmin = new ProxyPedido("1234", "admin");
        pedidoAdmin.Mostrar(); //Como é admin, entra no Pedido Real
    }
}
