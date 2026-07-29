namespace AspireApp.Model.PadraoComportamental.Strategy;

//Contexto, ou seja, onde o strategy será utilizado
public class Pedido
{
    private ICalculoValorStrategy _estrategia;

     public Pedido(ICalculoValorStrategy estrategia)
    {
        _estrategia = estrategia;
    }

    public void DefinirEstrategia(ICalculoValorStrategy estrategia)
    {
        _estrategia = estrategia;
    }

    public decimal Calcular(decimal valorBase, int desconto)
    {
        return _estrategia.CalcularValorFinalComImpostos(valorBase, desconto);
    }
}