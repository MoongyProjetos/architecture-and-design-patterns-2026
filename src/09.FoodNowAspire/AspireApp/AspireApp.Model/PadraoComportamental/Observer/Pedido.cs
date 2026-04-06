namespace AspireApp.Model.PadraoComportamental.Observer;

// Subject - Objeto a ser observado
// Observe o método NotificarClientes :)
public class Pedido
{
    private List<IClienteObserver> _clientes = new List<IClienteObserver>();
    public string Numero { get; }

    public Pedido(string numero)
    {
        Numero = numero;
    }

    public void AdicionarCliente(IClienteObserver cliente)
    {
        _clientes.Add(cliente);
    }

    public void AtualizarPedido(string detalhe)
    {
        Console.WriteLine($"Pedido {Numero} atualizado: {detalhe}");
        NotificarClientes($"Seu pedido {Numero} foi atualizado: {detalhe}");
    }

    private void NotificarClientes(string mensagem)
    {
        foreach (var cliente in _clientes)
        {
            cliente.Notificar(mensagem);
        }
    }
}