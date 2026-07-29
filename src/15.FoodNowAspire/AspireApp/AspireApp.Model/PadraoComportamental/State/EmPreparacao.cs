namespace AspireApp.Model.PadraoComportamental.State;

public class EmPreparacao : IEstadoPedido {
    public void Processar() => Console.WriteLine("🟡 O pedido está EM PREPARAÇÃO. Aguardando preparo.");
}