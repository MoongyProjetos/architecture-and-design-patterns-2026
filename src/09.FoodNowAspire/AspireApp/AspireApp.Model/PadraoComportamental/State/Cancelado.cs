namespace AspireApp.Model.PadraoComportamental.State;

public class Cancelado : IEstadoPedido
{
    public void Processar() => Console.WriteLine("❌ O pedido está CANCELADO. Nenhuma ação permitida.");
}