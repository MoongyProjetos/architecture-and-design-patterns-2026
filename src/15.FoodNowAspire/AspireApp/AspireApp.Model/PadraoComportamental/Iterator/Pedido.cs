namespace AspireApp.Model.PadraoComportamental.Iterator;

public class Pedido
{
    private List<ItemPedido> _itensPedido = new();

    public void Adicionar(ItemPedido itemPedido) => _itensPedido.Add(itemPedido);
    public IIteratorItemPedido CriarIterator() => new IteratorItemPedido(_itensPedido);
    
}