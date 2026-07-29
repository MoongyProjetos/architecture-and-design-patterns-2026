namespace AspireApp.Model.PadraoCriacional.Builder; 

// Implementação concreta
public class PedidoBuilder : IPedidoBuilder {
    private readonly Pedido _pedido = new Pedido();

    public void DefinirCliente(string cliente) => _pedido.Cliente = cliente;
    public void DefinirRestaurante(string restaurante) => _pedido.Restaurante = restaurante;
    public void AdicionarItem(string item) => _pedido.Itens.Add(item);
    public void DefinirEntrega(string tipo) => _pedido.TipoEntrega = tipo;
    public void AplicarCupom(string cupom) => _pedido.Cupom = cupom;

    public Pedido Construir() => _pedido;
}