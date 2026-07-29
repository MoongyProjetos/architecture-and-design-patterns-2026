namespace AspireApp.Model.PadraoCriacional.Builder; 

// Diretor
public class GeradorPedido {
    public Pedido CriarPedidoSimples(IPedidoBuilder builder) {
        builder.DefinirCliente("João");
        builder.DefinirRestaurante("Pizza Place");
        builder.AdicionarItem("Pizza Margherita");
        builder.DefinirEntrega("Normal");
        return builder.Construir();
    }

    public Pedido CriarPedidoCompleto(IPedidoBuilder builder) {
        builder.DefinirCliente("João");
        builder.DefinirRestaurante("Pizza Place");
        builder.AdicionarItem("Pizza Margherita");
        builder.AdicionarItem("Refrigerante");
        builder.DefinirEntrega("Expressa");
        builder.AplicarCupom("FOOD10");
        return builder.Construir();
    }
}