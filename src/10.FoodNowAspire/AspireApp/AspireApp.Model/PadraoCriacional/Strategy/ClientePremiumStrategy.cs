namespace AspireApp.Model.PadraoCriacional.Strategy;
public class ClientePremiumStrategy : IDescontoStrategy
{
    public decimal AplicarDesconto(decimal amount)
    {
        return amount * 0.8M;
    }
}