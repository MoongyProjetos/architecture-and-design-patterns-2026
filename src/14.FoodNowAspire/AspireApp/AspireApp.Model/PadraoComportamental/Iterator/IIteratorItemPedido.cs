namespace AspireApp.Model.PadraoComportamental.Iterator;

public interface IIteratorItemPedido
{
    bool TemProximo();
    ItemPedido ObterProximo();
}