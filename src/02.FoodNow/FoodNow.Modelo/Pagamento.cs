namespace  FoodNow.Modelo;

public class Pagamento
{
    public Guid Id { get; set; }
    public string? Tipo { get; set; }
    public decimal Valor { get; set; }
}