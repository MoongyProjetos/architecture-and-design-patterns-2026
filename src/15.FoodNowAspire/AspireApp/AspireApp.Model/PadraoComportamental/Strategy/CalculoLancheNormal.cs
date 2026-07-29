namespace AspireApp.Model.PadraoComportamental.Strategy;

public class CalculoLancheNormal : ICalculoValorStrategy
{
    //O algoritmo obviamente deve ser customizado de acordo com as regras da realidade
    //Aqui colocamos simplificado apenas para ajudar a didática
    public decimal CalcularValorFinalComImpostos(decimal valorBase, int valorDesconto)
    {
        const decimal valorIvaNormal = 0.10M;
        return valorBase * (1 + (valorIvaNormal - valorDesconto));
    }
}