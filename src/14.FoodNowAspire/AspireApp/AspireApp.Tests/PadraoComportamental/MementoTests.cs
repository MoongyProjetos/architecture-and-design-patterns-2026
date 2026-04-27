using AspireApp.Model.PadraoComportamental.Memento;

namespace AspireApp.Tests.PadraoComportamental.Memento;

public class MementoTests
{
    [Fact]
    public void DeveSerCapazDeRecuperarOPedidoQueNaoEstavaSalvoAinda()
    {
        var historicoPedido = new Historico();


        var pedido = new Pedido()
        {
            NomeCliente = "Maria 1",
            TipoDeRefeicao = "Hambúrguer"
        };

        var memento = pedido.CriarMemento();
        historicoPedido.Salvar(memento);

        pedido.NomeCliente = "Maria da Silva 2 ";
        pedido.TipoDeRefeicao = "Hamburguer sem carne 2";
        var memento2 = pedido.CriarMemento();
        historicoPedido.Salvar(memento2);


        pedido.NomeCliente = "Maria da Silva 3 ";
        pedido.TipoDeRefeicao = "Hamburguer sem carne 3 ";
        Console.WriteLine($"Cliente:{pedido.NomeCliente} - Pedido:{pedido.TipoDeRefeicao}");

        //recuperar memento
        pedido.Restaurar(memento);
        Console.WriteLine($"Cliente:{pedido.NomeCliente} - Pedido:{pedido.TipoDeRefeicao}");

        //Se eu quiser usar o conceito de historico - na primeira vez, pega a Maria 2
        var mementoAnterior = historicoPedido.Desfazer();
        pedido.Restaurar(mementoAnterior);
        Console.WriteLine($"Cliente:{pedido.NomeCliente} - Pedido:{pedido.TipoDeRefeicao}");

        //Se eu quiser usar o conceito de historico - na segunda vez, pega a Maria 1
        mementoAnterior = historicoPedido.Desfazer();
        pedido.Restaurar(mementoAnterior);
        Console.WriteLine($"Cliente:{pedido.NomeCliente} - Pedido:{pedido.TipoDeRefeicao}");
    }
}
