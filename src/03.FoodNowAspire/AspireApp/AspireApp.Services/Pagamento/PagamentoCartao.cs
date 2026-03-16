namespace AspireApp.Services.Pagamento;

public class PagamentoCartao : PagamentoFactoryMethod
{
    public override void Processar(){
        Console.WriteLine("Pagamento especifico Cartão");
    }
}