namespace AspireApp.Model.PadraoCriacional.Builder; 

// Builder
public interface IPedidoBuilder
{
    void DefinirCliente(string cliente);
    void DefinirRestaurante(string restaurante);
    void AdicionarItem(string item);
    void DefinirEntrega(string tipo);
    void AplicarCupom(string cupom);
    Pedido Construir();
}