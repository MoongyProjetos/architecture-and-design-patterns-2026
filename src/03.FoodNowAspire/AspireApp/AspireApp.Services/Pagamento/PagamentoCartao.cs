namespace AspireApp.Services.Fatura;

public class PagamentoCartao : PagamentoFactoryMethod
{
    public override void Processar(){
        Console.WriteLine("Pagamento especifico Cartão");
    }
}