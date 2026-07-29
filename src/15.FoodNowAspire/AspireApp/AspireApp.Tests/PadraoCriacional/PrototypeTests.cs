using AspireApp.Model.PadraoCriacional.Prototype;


namespace AspireApp.Tests.PadraoCriacional;

public class PrototypeTests
{
    [Fact]
    public void DeveGerarUmPedidoNovoClonandoDadosDoPedidoAntigo()
    {
        // Given
        var pedidoAnterior = new Pedido {
            Restaurante = "Pizza Place",
            Itens = new List<string> { "Pizza", "Refrigerante" },
            TipoEntrega = "Normal"
        };
    
        // When
        // Cliente repete o pedido
        var novoPedido = pedidoAnterior.Clone();
        novoPedido.TipoEntrega = "Expressa"; // customização
    
        // Then
        Assert.Equal("Normal", pedidoAnterior.TipoEntrega);
        Assert.Equal("Pizza Place", pedidoAnterior.Restaurante);
        Assert.Equal(2, pedidoAnterior.Itens.Count());

        Assert.Equal("Expressa", novoPedido.TipoEntrega);
        Assert.Equal("Pizza Place", novoPedido.Restaurante);
        Assert.Equal(2, novoPedido.Itens.Count());

        //Cuidado, não devo usar testes com duas variantes assim        
        Assert.Equal(pedidoAnterior.Restaurante, novoPedido.Restaurante);
        Assert.Equal(pedidoAnterior.Itens.Count(), novoPedido.Itens.Count());
    }    
}