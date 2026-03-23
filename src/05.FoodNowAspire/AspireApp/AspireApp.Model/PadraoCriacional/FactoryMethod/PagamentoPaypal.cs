namespace AspireApp.Model.PadraoCriacional.FactoryMethod;

public class PagamentoPaypal : PagamentoFactoryMethod
{
    public override void Processar(){
        Console.WriteLine("Pagamento especifico Paypal");
    }
}