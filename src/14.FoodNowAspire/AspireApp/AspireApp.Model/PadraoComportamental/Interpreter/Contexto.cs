namespace AspireApp.Model.PadraoComportamental.Interpreter;

// Contexto com os dados de entrada da regra
//Vamos verificar se o cliente tem carteirinha de estudante ou se tem menos de 18 anos
public class Contexto {
    public int Idade { get; set; }
    public bool TemCarteirinhaDaFaculdade { get; set; }
}