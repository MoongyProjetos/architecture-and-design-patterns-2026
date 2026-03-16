namespace AspireApp.Services.Desconto;
public class ClientePremiumStrategy : IDescontoStrategy
{
    public decimal AplicarDesconto(decimal amount)
    {
        return amount * 0.8M;
    }
}