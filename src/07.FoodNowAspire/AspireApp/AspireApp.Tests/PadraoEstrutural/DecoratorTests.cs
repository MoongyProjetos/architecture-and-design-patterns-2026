namespace AspireApp.Tests.PadraoEstrutural.Decorator;

using AspireApp.Model.PadraoEstrutural.Decorator;
public class DecoratorTests
{
    [Fact]
    public void ExemploUsoDecorator()
    {
        // Given        
        var pedido = new PedidoBase();      
        
        // When        
        var pedidoComQueijo = new ComQueijo(pedido);      
        Console.WriteLine(pedido.Descricao());
   
        // Then
        Assert.Equal(10, pedido.CalcularPreco());
        Assert.Equal(12, pedidoComQueijo.CalcularPreco());
    }


    [Fact]
    [Molho]
    public void ExemploUsoDecoratorComoAtributo()
    {
        //Vai mostrar no Console o comportamento do Attributo, 
        // Molho, que significa mostra uma mensagem
        // Given        
        var pedido = new PedidoBase();      
        
        // // When
        var pedidoComQueijo = new ComMaionese(pedido);    
        Console.WriteLine(pedidoComQueijo.Descricao());  
   
        // // Then
        Assert.Equal(10, pedido.CalcularPreco());
        Assert.Equal(13, pedidoComQueijo.CalcularPreco());
    }
}
