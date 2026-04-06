namespace AspireApp.Model.PadraoComportamental.Visitor;

// Interface do visitante
public interface IVisitor {
    void Visitar(HappyMeal pedido);
    void Visitar(PedidoNormal pedido);
    void Visitar(PedidoVegano pedido);
}