namespace AspireApp.Model.PadraoComportamental.Strategy;

// Strategy
public interface ICalculoValorStrategy
{
    decimal CalcularValorFinalComImpostos(decimal valorBase, int valorDesconto);
}