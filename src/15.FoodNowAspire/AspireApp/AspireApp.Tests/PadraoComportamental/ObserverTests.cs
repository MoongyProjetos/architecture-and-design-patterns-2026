namespace AspireApp.Tests.PadraoComportamental;

using AspireApp.Model.PadraoComportamental.Observer;
public class ObserverTests
{
    [Fact]
    public void DeveNotificarTodosOsClientesSempreQueUmPedidoForAlterado()
    {
        var pedido = new Pedido("Pedido 1234");
        var cliente1 = new Cliente("Ana");
        var cliente2 = new Cliente("José");

        pedido.AdicionarCliente(cliente1);
        pedido.AdicionarCliente(cliente2);

        pedido.AtualizarPedido("O pedido foi atualizado");        
    }
}