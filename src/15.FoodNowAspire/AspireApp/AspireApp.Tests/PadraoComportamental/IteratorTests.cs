using AspireApp.Model.PadraoComportamental.Iterator;

namespace AspireApp.Tests.PadraoComportamental.Iterator;

public class InterpreterTests
{
    [Fact]
    public void DeveChamarMetodosInternosComBaseEmUmIterador()
    {
        var pedido = new Pedido();

        var itemPedido1 = new ItemPedido
        {
            Nome = "Hambúrguer",
            Descricao = "Hambúrguer Especial",
            Observacao = "Sem tomate",
            Valor = 10            
        };
        pedido.Adicionar(itemPedido1);

        var itemPedido2 = new ItemPedido
        {
            Nome = "Chesebúrguer",
            Descricao = "Chesebúrguer Especial",
            Observacao = "",
            Valor = 15            
        };
        pedido.Adicionar(itemPedido2);
        
        var iterator =  pedido.CriarIterator();

        while(iterator.TemProximo())
        {
            var p = iterator.ObterProximo();
            p.FalarNome();
        }
    }
}