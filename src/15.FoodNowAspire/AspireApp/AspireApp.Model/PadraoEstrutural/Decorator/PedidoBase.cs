namespace AspireApp.Model.PadraoEstrutural.Decorator;

public class PedidoBase : IPedido {
    public string Descricao() => "Hambúrguer";
    public decimal CalcularPreco() => 10;
}