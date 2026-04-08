namespace AspireApp.Model.PadraoComportamental.Visitor;

public class FaturaSimplificada : IVisitor
{
    public void Visitar(HappyMeal pedido)=> Console.WriteLine($"Fatura do HappyMeal: descricao = {pedido.Descricao} e brinquedo = {pedido.Brinquedo}");
    public void Visitar(PedidoNormal pedido)=> Console.WriteLine($"Fatura do Pedido Normal: descricao = {pedido.Descricao}");
    public void Visitar(PedidoVegano pedido)=> Console.WriteLine($"Fatura do Pedido Vegano: descricao = {pedido.Descricao}");
}