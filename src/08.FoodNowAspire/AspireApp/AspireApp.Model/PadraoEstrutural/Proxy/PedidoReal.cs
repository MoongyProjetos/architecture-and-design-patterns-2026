namespace AspireApp.Model.PadraoEstrutural.Proxy;

/// <summary>
/// Classe com lógica "pesada" que o Proxy controla o acesso
/// </summary>
public class PedidoReal : IPedidoDetalhado
{
    private readonly string _pedidoId;

    public PedidoReal(string pedidoId) => _pedidoId = pedidoId;

    public string Mostrar()
    {
        return $"Detalhes do pedido {_pedidoId}";
    }
}