using System.Reflection;

namespace AspireApp.Model.PadraoEstrutural.Decorator;

[Molho("Mostarda")]
public class ComMolho : IPedido {
    private readonly IPedido _pedido;
    public ComMolho(IPedido pedido) => _pedido = pedido;

    public string Descricao()
    {
        var type = typeof(ComMolho);
        var atributo = (MolhoAttribute)Attribute.GetCustomAttribute(type, typeof(MolhoAttribute));
        var resultado = _pedido.Descricao() + " + Molho" + atributo.Tipo;
        return resultado;
    } 
    public decimal CalcularPreco() => _pedido.CalcularPreco() + 2;
}