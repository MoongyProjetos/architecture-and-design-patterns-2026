using AspireApp.Model.PadraoCriacional.ObjectPool;

namespace  AspireApp.Tests.PadraoCriacional;

public class ObjectPoolTests
{
    [Fact]
    public void DeveGerarUmPoolDe2FornosEValidarQueForamDisponibilizados()
    {
        // Given
        var pool = new FornoPool(2);
        var pedido = new Pedido();
   
        // When
        var forno1 = pool.GetForno();
        forno1.PrepararPedido(pedido);
        pool.DevolverForno(forno1);

        var forno2 = pool.GetForno();
        forno2.PrepararPedido(pedido);
        pool.DevolverForno(forno2);
    
        // Then
        Assert.Equal(2, pool.FornosTotais);
        Assert.Equal(1, pool.FornosDisponiveis);
    }


    [Fact]
    public void DeveGerarUmPoolDe2FornosEReaproveitarOsObjetos()
    {
        // Given
        var pool = new FornoPool(2);
        var pedido = new Pedido();
   
        // When
        var forno1 = pool.GetForno();
        forno1.PrepararPedido(pedido);
        pool.DevolverForno(forno1);

        var forno2 = pool.GetForno();
        forno2.PrepararPedido(pedido);
    
        // Then
        Assert.Equal(2, pool.FornosTotais);
        Assert.Equal(0, pool.FornosDisponiveis);
    }



    [Fact]
    public void DeveGerarUmPoolDe1FornosEReaproveitarOsObjetos()
    {
        // Given
        var pool = new FornoPool(1);
        var pedido = new Pedido();
   
        // When
        var forno1 = pool.GetForno();
        forno1.PrepararPedido(pedido);
        pool.DevolverForno(forno1);

        var forno2 = pool.GetForno();
        forno2.PrepararPedido(pedido);
    
        // Then
        Assert.Equal(1, pool.FornosTotais);
        Assert.Equal(0, pool.FornosDisponiveis);
    }


    [Fact]
    public void DeveGerarUmPoolDe1FornosEGerarException()
    {
        // Given
        var pool = new FornoPool(1);
        var pedido = new Pedido();
   
        // When
        var forno1 = pool.GetForno();
        forno1.PrepararPedido(pedido);

        var ex = Assert.Throws<InvalidOperationException>(pool.GetForno);
        Assert.Equal("Nenhum Forno disponível no pool.", ex.Message);
    }

}
