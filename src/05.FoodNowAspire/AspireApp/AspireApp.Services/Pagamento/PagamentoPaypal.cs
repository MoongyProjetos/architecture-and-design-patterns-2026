namespace AspireApp.Services.Pagamento;

public class PagamentoPaypal : PagamentoFactoryMethod
{
    public override void Processar(){
        Console.WriteLine("Pagamento especifico Paypal");
    }
}