namespace FoodNow.Modelo;

class EntregadorBicicleta : Entregador
{
    public string TamanhoCaixa {get;set;}

    public override decimal CalcularFrete()
    {
        return 10;
    }
}