namespace AspireApp.Services.Pagamento;
public class PagamentoMBWay : PagamentoFactoryMethod
{
    public override void Processar(){
        Console.WriteLine("Pagamento especifico MBWay");
    }
}