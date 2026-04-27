namespace AspireApp.Model.PadraoEstrutural.Decorator;

[Molho("Mostarda")]
public class ComMostarda : ComMolhoAbstrata {
    public ComMostarda(IPedido pedido) : base (pedido) {}

    //Por algum motivo, resolvi que o preço da Mostarda acrescenta 10% ao valor do hamburguer
    public override decimal CalcularPreco() => _pedido.CalcularPreco() * 1.1M;
}