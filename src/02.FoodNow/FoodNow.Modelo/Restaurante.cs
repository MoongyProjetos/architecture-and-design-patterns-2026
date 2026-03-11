namespace  FoodNow.Modelo;

public class Restaurante
{
    public Guid Id { get; set; }    
    public string? Nome { get; set; }    
    public Endereco Endereco { get; set; }    
}