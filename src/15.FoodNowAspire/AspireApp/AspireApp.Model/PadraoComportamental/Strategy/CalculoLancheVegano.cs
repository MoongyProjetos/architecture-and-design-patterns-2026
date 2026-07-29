namespace AspireApp.Model.PadraoComportamental.Strategy;

public class CalculoLancheVegano : ICalculoValorStrategy
{
    public decimal CalcularValorFinalComImpostos(decimal valorBase, int valorDesconto)
    {
        const decimal valorIvaVegano = 0.23M;
        return valorBase * (1 + (valorIvaVegano - valorDesconto));
    }
}