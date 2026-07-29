namespace AspireApp.Model.PadraoCriacional.Prototype; 

// Classe concreta
public class Pedido : IPedidoPrototype {
    public string Restaurante { get; set; }
    public List<string> Itens { get; set; }
    public string TipoEntrega { get; set; }

    public Pedido Clone() {
        return new Pedido {
            Restaurante = Restaurante,
            Itens = [.. Itens], // Deep copy da lista
            TipoEntrega = TipoEntrega
        };
    }
}