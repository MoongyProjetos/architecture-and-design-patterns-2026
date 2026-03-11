namespace FoodNow.Modelo;

class EntregadorCarro : Entregador
{
    public string ModeloCarro {get;set;}

    public override decimal CalcularFrete()
    {
        return 15;
    }
}