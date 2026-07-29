namespace AspireApp.Model.PadraoComportamental.Memento;

public class Historico
{
    private Stack<MementoPedido> _mementos = new();

    public void Salvar(MementoPedido memento) => _mementos.Push(memento);
    public MementoPedido Desfazer() => _mementos.Pop();
}