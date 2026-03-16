namespace AspireApp.Services;

using AspireApp.Services.Desconto;

public class Fatura
{
    public decimal CalcularTotal(IDescontoStrategy estrategia, decimal valorTotal)
    {
        return estrategia.AplicarDesconto(valorTotal);
    }
}

