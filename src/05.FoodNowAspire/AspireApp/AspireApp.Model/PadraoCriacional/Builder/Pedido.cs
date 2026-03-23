namespace AspireApp.Model.PadraoCriacional.Builder; 

// Produto final
public class Pedido
{
    public string Cliente { get; set; }
    public string Restaurante { get; set; }
    public List<string> Itens { get; set; } = new();
    public string TipoEntrega { get; set; }
    public string Cupom { get; set; }

    public override string ToString() {
        return $"{Cliente} pediu {string.Join(", ", Itens)} de {Restaurante} " +
               $"(Entrega: {TipoEntrega}, Cupom: {Cupom})";
    }
}