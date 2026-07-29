using AspireApp.Model.PadraoComportamental.State;

namespace AspireApp.Tests.PadraoComportamental.State;

public class StateTests
{
    [Fact]
    public void PedidoDeveSeComportarDeAcordoComSeuEstado()
    {
        var pedido = new Pedido("Pedido 1234", 123, new List<string>());

        // Pedido ainda sem estado
        pedido.Processar();

        // Estado: Em preparacao
        pedido.DefinirEstado(new EmPreparacao());
        pedido.Processar();

        // Estado: Emitida
        pedido.DefinirEstado(new Encomendado());
        pedido.Processar();

        // Estado: Cancelada
        pedido.DefinirEstado(new Cancelado());
        pedido.Processar();

        // Estado: Expirada
        pedido.DefinirEstado(new Expirado());
        pedido.Processar();
    }
}
