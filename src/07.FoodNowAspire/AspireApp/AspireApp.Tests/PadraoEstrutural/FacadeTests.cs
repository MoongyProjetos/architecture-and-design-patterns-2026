namespace AspireApp.Tests.PadraoEstrutural.Facade;

using AspireApp.Model.PadraoEstrutural.Facade;
public class FacadeTests
{
    [Fact]
    public void ExemploUsoFacade()
    {
        // Given        
        var pedido = new PedidoFacade();      
        
        // When        
        pedido.FazerPedido("hamburguer", 10);
   
        // Then        
    }
}
