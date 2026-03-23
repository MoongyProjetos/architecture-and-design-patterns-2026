namespace AspireApp.Services.Fatura;

using AspireApp.Services.Desconto;
using AspireApp.Services.Pagamento;
using AspireApp.Services.Entrega;

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

    //TODO: Local Temporario para o Método de Entrega. Verificar onde colocar isso.
    public void EfetuarEntrega(EntregaAbstractFactory entrega)
    {
        entrega.EfetuarEntrega();
    }
}


