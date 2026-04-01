namespace AspireApp.Model.PadraoEstrutural.Decorator;

public class ComQueijo : IPedido {
    private readonly IPedido _pedido;
    public ComQueijo(IPedido pedido) => _pedido = pedido;

    public string Descricao() => _pedido.Descricao() + " + Queijo";
    public decimal CalcularPreco() => _pedido.CalcularPreco() + 2;
}