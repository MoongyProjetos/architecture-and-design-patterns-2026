using  AspireApp.Model.PadraoEstrutural.Facade.Subsystems;

namespace AspireApp.Model.PadraoEstrutural.Facade;

// Facade
public class PedidoFacade {
    private readonly PagamentoService _pagamento = new();
    private readonly RestauranteService _restaurante = new();
    private readonly EntregaService _entrega = new();

    public void FazerPedido(string item, decimal valor) {
        _pagamento.Processar(valor);
        _restaurante.PrepararPedido(item);
        _entrega.EnviarEntrega();
    }
}