namespace FoodNow.Modelo;

public class Pedido
{
    public Guid Id { get; set; }
    public DateTime DataPedido { get; set; }
    public List<string>? ItensPedido { get; set; }
    public Cliente? Cliente { get; set; }
    public Entregador? Entregador { get; set; }
    public Restaurante? Restaurante { get; set; }
}