namespace AspireApp.Model.PadraoComportamental.State;

public class Expirado : IEstadoPedido {
    public void Processar() => Console.WriteLine("⚪ O Pagamento do Pedido está EXPIRADO. Pedido precisa ser refeito.");
}