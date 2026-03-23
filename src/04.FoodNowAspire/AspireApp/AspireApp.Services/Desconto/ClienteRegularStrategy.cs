namespace AspireApp.Services.Desconto;
public class ClienteRegularStrategy : IDescontoStrategy
{
    public decimal AplicarDesconto(decimal amount)
    {
        return amount * 0.9M;
    }
}