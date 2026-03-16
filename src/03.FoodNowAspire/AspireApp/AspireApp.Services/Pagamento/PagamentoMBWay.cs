namespace AspireApp.Services.Fatura;

public class PagamentoMBWay : PagamentoFactoryMethod
{
    public override void Processar(){
        Console.WriteLine("Pagamento especifico MBWay");
    }
}