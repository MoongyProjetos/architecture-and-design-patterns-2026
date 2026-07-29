namespace AspireApp.Model.PadraoComportamental.Interpreter;

public class OU : IExpressao {
    private IExpressao _esq, _dir;
    public OU(IExpressao e1, IExpressao e2) { _esq = e1; _dir = e2; }
    public bool Interpretar(Contexto c) => _esq.Interpretar(c) || _dir.Interpretar(c);
}