namespace AspireApp.Model.PadraoComportamental.Interpreter;

// Expressão: possui carteira de estudante
public class PossuiCarteiraEstudante : IExpressao {
    public bool Interpretar(Contexto contexto) => contexto.TemCarteirinhaDaFaculdade;
}