namespace AspireApp.Model.PadraoComportamental.Interpreter;

// Expressão: idade < 19
public class TemIdadeMenorQue19 : IExpressao {
    public bool Interpretar(Contexto contexto) => contexto.Idade < 19;
}