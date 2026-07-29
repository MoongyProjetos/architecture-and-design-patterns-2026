namespace AspireApp.Model.PadraoComportamental.NullObject;

public class Pedido : IPedido
{
    private readonly string _itens;
    public Pedido(string itens) => _itens = itens;
    public string ObterItens() => _itens;
}