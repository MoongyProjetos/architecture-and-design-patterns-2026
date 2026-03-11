namespace FoodNow.Logica;
public class Pagamentos
{
    public IFaturacao faturacao;

    public void FinalizarPedido()
    {
        var f = new FaturaEletronicaComDadosFinanca();
        f.Imprimir();
    }


    // public void FinalizarPedido()
    // {
    //     faturacao.Imprimir();
    // }
}