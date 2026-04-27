namespace AspireApp.Tests.PadraoComportamental.Strategy;

using AspireApp.Model.PadraoComportamental.Strategy;
public class ObserverTests
{
    [Fact]
    public void DeveAplicarAlgoritmoDinamicamenteOValorParaLancheVegano()
    {
        var pedido = new Pedido(new CalculoLancheVegano());        
        var valor = pedido.Calcular(100, 0);
        Assert.Equal(123, valor);
    }


    [Fact]
    public void DeveAplicarAlgoritmoDinamicamenteOValorParaLancheNormal()
    {
        var pedido = new Pedido(new CalculoLancheNormal());        
        var valor = pedido.Calcular(100, 0);
        Assert.Equal(110, valor);
    }
}