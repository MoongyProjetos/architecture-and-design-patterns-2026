namespace AspireApp.Model.PadraoCriacional.FactoryMethod;
public class PagamentoMBWay : PagamentoFactoryMethod
{
    public override void Processar(){
        Console.WriteLine("Pagamento especifico MBWay");
    }
}