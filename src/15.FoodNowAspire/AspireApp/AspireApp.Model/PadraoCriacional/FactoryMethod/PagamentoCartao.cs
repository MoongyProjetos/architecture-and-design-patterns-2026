namespace AspireApp.Model.PadraoCriacional.FactoryMethod;

public class PagamentoCartao : PagamentoFactoryMethod
{
    public override void Processar(){
        Console.WriteLine("Pagamento especifico Cartão");
    }
}