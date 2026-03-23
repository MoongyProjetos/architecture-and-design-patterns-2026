namespace AspireApp.Tests.PadraoCriacional;

using System.Reflection;
using AspireApp.Model.PadraoCriacional.Builder;

public class BuilderTests
{
    [Fact]
    public void DeveGerarUmPedidoSimplesComApenasUmItem()
    {
        // Given
        IPedidoBuilder pedidoBuilder = new PedidoBuilder();
        GeradorPedido diretor = new GeradorPedido();

        // When
        Pedido pedido = diretor.CriarPedidoSimples(pedidoBuilder); 
    
        // Then
        Assert.Equal(1, pedido.Itens.Count());
        Assert.Equal("João", pedido.Cliente);
        Assert.Null(pedido.Cupom);  
    }

    [Fact]
    public void DeveGerarUmPedidoCompletoComNItensCupom()
    {
        // Given
        IPedidoBuilder pedidoBuilder = new PedidoBuilder();
        GeradorPedido diretor = new GeradorPedido();

        // When
        Pedido pedido = diretor.CriarPedidoCompleto(pedidoBuilder); 
    
        // Then
        Assert.Equal(2, pedido.Itens.Count());
        Assert.Equal("João", pedido.Cliente);
        Assert.Equal("FOOD10", pedido.Cupom);
    }
}