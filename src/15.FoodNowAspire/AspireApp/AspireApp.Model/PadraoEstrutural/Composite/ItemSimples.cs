using AspireApp.Model.PadraoEstrutural.Composite;

public class ItemSimples : ItemCompra
{
    private readonly decimal _price;

    public ItemSimples(decimal price) {
        _price = price;
    }

    public override decimal ObterPreco() => _price;
}