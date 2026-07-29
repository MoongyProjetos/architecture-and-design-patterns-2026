namespace AspireApp.Model.PadraoEstrutural.Decorator;

public class ComBacon : IPedido {
    private readonly IPedido _pedido;
    public ComBacon(IPedido pedido) => _pedido = pedido;

    public string Descricao() => _pedido.Descricao() + " + Bacon";
    public decimal CalcularPreco() => _pedido.CalcularPreco() + 3;
}