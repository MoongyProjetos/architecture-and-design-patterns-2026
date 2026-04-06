namespace AspireApp.Model.PadraoComportamental.ChainOfResponsability;

//Nível 1 - Pedidos até 1000 euros (normal do balcão)
public class Gerente : Aprovador
{
    public override void Aprovar(Pedido pedido)
    {
        if(pedido.Valor <= 5000)
        {
            Console.WriteLine($"Gerente aprovou o pedido: {pedido.Descricao} (Valor: {pedido.Valor:C})");
        }else
        {
            Proximo?.Aprovar(pedido);
        }
    }
}