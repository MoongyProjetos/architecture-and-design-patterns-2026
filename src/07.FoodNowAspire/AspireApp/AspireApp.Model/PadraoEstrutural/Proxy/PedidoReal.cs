namespace AspireApp.Model.PadraoEstrutural.Proxy;

/// <summary>
/// Essa é a classe de exemplo, com o código complexo que queremos esconder :)
/// </summary>
public class PedidoReal : IPedidoDetalhado {
    private readonly string _pedidoId;

    public PedidoReal(string pedidoId) {
        _pedidoId = pedidoId;
        Console.WriteLine($"Carregando pedido {_pedidoId}");
    }

    public void Mostrar() =>
        Console.WriteLine($"Detalhes do pedido {_pedidoId}");
}