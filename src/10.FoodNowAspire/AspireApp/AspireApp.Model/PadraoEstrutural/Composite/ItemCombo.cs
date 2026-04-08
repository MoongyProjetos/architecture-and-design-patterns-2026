using AspireApp.Model.PadraoEstrutural.Composite;

public class ItemCombo : ItemCompra
{
    private readonly List<ItemCompra> _items = new();

    public void Adicionar(ItemCompra item) => _items.Add(item);

    public override decimal ObterPreco() => _items.Sum(i => i.ObterPreco());
}