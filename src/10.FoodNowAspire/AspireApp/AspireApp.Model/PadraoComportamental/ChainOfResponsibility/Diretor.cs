namespace AspireApp.Model.PadraoComportamental.ChainOfResponsability;

//Nível 1 - Pedidos até 1000 euros (normal do balcão)
public class Diretor : Aprovador
{
    public override void Aprovar(Pedido pedido)
    {
        if(pedido.Valor <= 100000)
        {
            Console.WriteLine($"Diretor aprovou o pedido: {pedido.Descricao} (Valor: {pedido.Valor:C})");
        }else
        {
            Console.WriteLine($"Pedido de valor muito alto! Escalar para Supervisor da cadeia: {pedido.Descricao} (Valor: {pedido.Valor:C})");
        }
    }
}