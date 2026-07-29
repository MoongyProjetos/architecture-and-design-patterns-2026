namespace AspireApp.Model.PadraoComportamental.NullObject;

public class PedidoNull : IPedido
{
    public string ObterItens() => "Itens não definidos";
}