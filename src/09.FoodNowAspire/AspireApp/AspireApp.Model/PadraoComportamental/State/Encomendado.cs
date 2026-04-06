namespace AspireApp.Model.PadraoComportamental.State;

public class Encomendado : IEstadoPedido {
    public void Processar() => Console.WriteLine("🔵 O pedido foi ENCOMENDADO e pode ser pago.");
}