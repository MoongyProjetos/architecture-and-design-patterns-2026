namespace AspireApp.Model.PadraoComportamental.Iterator;

public class IteratorItemPedido : IIteratorItemPedido
{
    private readonly List<ItemPedido> _itensPedido;
    private int _indiceAtual = 0;

    public IteratorItemPedido(List<ItemPedido> itensPedido)
    {
        _itensPedido = itensPedido;
    }
    
    public ItemPedido ObterProximo() => _itensPedido[_indiceAtual++];

    public bool TemProximo() => _indiceAtual < _itensPedido.Count;
}