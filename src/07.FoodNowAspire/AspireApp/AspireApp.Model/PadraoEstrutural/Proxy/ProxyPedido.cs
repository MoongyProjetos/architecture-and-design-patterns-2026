namespace AspireApp.Model.PadraoEstrutural.Proxy;

//Aqui utilizamos o Proxy por dois motivos: 1 - Esconder complexidade 
//2 - Esconder/Conceder permissões apenas a quem se deve
public class ProxyPedido : IPedidoDetalhado {
    private PedidoReal _real;
    private readonly string _pedidoId;
    private readonly string _usuario;

    public ProxyPedido(string pedidoId, string usuario) {
        _pedidoId = pedidoId;
        _usuario = usuario;
    }

    public void Mostrar() {
        if (_usuario != "admin")
        {
            Console.WriteLine("Acesso negado");
        }            
        else {
            _real ??= new PedidoReal(_pedidoId);
            _real.Mostrar();
        }
    }
}