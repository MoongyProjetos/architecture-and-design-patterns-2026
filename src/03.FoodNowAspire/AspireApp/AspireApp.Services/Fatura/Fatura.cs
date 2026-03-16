namespace AspireApp.Services.Fatura;

using AspireApp.Services.Desconto;

public class Fatura
{
    public decimal CalcularTotal(IDescontoStrategy estrategia, decimal valorTotal)
    {
        return estrategia.AplicarDesconto(valorTotal);
    }

    //TODO: Local Temporario para o Método de Pagamento. Verificar onde colocar isso.
    public void EfetuarPagamento(PagamentoFactoryMethod pagamento)
    {
        pagamento.Processar();
    }

}

