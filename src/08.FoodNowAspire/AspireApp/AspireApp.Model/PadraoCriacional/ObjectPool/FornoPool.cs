namespace AspireApp.Model.PadraoCriacional.ObjectPool; 

public class FornoPool
{
    private readonly Stack<Forno> _disponiveis = new();

    private readonly int _maximo;
    private int _emUso = 0;

    public FornoPool(int maximo) => _maximo = maximo;

    public Forno GetForno() {
        if (_disponiveis.Count > 0) {
            _emUso++;
            return _disponiveis.Pop();
        }
        if (_emUso < _maximo) {
            _emUso++;
            return new Forno();
        }
        throw new InvalidOperationException("Nenhum Forno disponível no pool.");
    }

    public void DevolverForno(Forno forno) {
        _disponiveis.Push(forno);
        _emUso--;
    }


    /// <summary>
    /// Apenas para questões didáticas estou expondo o número de fornos disponíveis
    /// </summary>
    public int FornosTotais => _maximo;
    public int FornosDisponiveis => _disponiveis.Count;
    
}