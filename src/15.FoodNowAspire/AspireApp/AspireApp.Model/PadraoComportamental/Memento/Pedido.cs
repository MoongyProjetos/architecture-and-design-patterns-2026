namespace AspireApp.Model.PadraoComportamental.Memento;

public class Pedido
{
    public string NomeCliente { get; set; }
    public string TipoDeRefeicao { get; set; }

    public MementoPedido CriarMemento() => new(NomeCliente, TipoDeRefeicao);
    public void Restaurar(MementoPedido memento)
    {
        NomeCliente = memento.NomeCliente;
        TipoDeRefeicao = memento.TipoDeRefeicao;
    }
}