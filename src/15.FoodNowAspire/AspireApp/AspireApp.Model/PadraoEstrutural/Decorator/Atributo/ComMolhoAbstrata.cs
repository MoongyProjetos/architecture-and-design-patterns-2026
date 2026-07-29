namespace AspireApp.Model.PadraoEstrutural.Decorator;

[Molho()]
public abstract class ComMolhoAbstrata : IPedido {
    protected readonly IPedido _pedido;
    protected ComMolhoAbstrata(IPedido pedido) => _pedido = pedido;

    public virtual string Descricao()
    {
        var type = typeof(ComMaionese);
        var atributo = (MolhoAttribute)Attribute.GetCustomAttribute(type, typeof(MolhoAttribute));
        var resultado = _pedido.Descricao() + " + Molho" + atributo.Tipo;
        return resultado;
    } 
    public virtual decimal CalcularPreco() => _pedido.CalcularPreco() + 3;
}