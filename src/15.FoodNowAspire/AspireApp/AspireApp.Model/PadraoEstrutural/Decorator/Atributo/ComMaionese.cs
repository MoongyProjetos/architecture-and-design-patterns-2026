namespace AspireApp.Model.PadraoEstrutural.Decorator;

[Molho("Maionese")]
public class ComMaionese : ComMolhoAbstrata {
    public ComMaionese(IPedido pedido) : base (pedido) {}
}