namespace AspireApp.Model.PadraoComportamental.State;

public class Pedido
{
    public string Descricao { get; set; }

    public decimal Valor { get; set; }
    public List<string> Itens { get; set; }

    public Pedido(string descricao, decimal valor, List<string> itens)
    {
        Descricao = descricao;
        Valor = valor;
        Itens = itens;
    }

    //Propriedade que determina o estado atual do pedido
    private IEstadoPedido _estado;

    public void DefinirEstado(IEstadoPedido estado)
    {
        _estado = estado;
        Console.WriteLine($"[Estado atualizado: {estado.GetType().Name}]");
    }

    public void Processar()
    {
        if (_estado == null)
            Console.WriteLine("⚠️ Nenhum estado definido para o pedido.");
        else
            _estado.Processar();
    }
}