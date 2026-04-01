namespace AspireApp.Model.PadraoCriacional.ObjectPool; 

public class Forno {
    public void PrepararPedido(Pedido pedido) {
        
        // Simula processamento pesado
        Thread.Sleep(1000);
    }
}