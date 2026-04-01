namespace AspireApp.Model.PadraoEstrutural.Proxy;

public class ProxyPedido : IPedidoDetalhado
{
    private readonly IPedidoDetalhado _real;
    private readonly string _usuario;

    public ProxyPedido(IPedidoDetalhado real, string usuario)
    {
        _real = real;
        _usuario = usuario;
    }

    public string Mostrar()
    {
        if (_usuario != "admin")
            return "Acesso negado";

        return _real.Mostrar();
    }
}