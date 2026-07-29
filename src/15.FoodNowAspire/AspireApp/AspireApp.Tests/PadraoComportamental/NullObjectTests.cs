using AspireApp.Model.PadraoComportamental.NullObject;

namespace AspireApp.Tests.PadraoComportamental.NullObject;

public class NullObjectTests
{
    [Fact]
    public void DeveSerCapazDeLidarComObjetoNulo()
    {
        Console.WriteLine("Exemplo de uso do Null Object:");

        var pedido = new Pedido("sanduíche");
        var pedido2 = new Pedido("batatas");
        var PedidoIncompleto = new PedidoNull();

        // Exibindo informações do cliente
        Console.WriteLine("Informações do Pedido:");
        var colecao = new List<IPedido> { pedido, pedido2, PedidoIncompleto };

        foreach (var c in colecao)
        {
            Console.WriteLine($"Itens: {c.ObterItens()}");
        }
    }
}