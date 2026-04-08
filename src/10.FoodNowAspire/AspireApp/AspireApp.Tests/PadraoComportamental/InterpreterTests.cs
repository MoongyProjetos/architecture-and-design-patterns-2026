using AspireApp.Model.PadraoComportamental.Interpreter;

namespace AspireApp.Tests.PadraoComportamental.Interpreter;

public class InterpreterTests
{
    [Fact]
    public void DevePermitirDescontoSeForEstudanteOuMenorDeIdadeUsandoRegraE()
    {
        // Criar a expressão: idade < 19 AND tem carteira estudante
        IExpressao regra = new E(new TemIdadeMenorQue19(), new PossuiCarteiraEstudante());

        // Teste 1
        var cliente1 = new Contexto { Idade = 30, TemCarteirinhaDaFaculdade = true };
        Console.WriteLine("Cliente 1 tem desconto? " + regra.Interpretar(cliente1)); // false

        // Teste 2
        var cliente2 = new Contexto { Idade = 12, TemCarteirinhaDaFaculdade = true };
        Console.WriteLine("Cliente 2 tem desconto? " + regra.Interpretar(cliente2)); // true

        // Teste 3
        var cliente3 = new Contexto { Idade = 28, TemCarteirinhaDaFaculdade = false };
        Console.WriteLine("Cliente 3 aprovado? " + regra.Interpretar(cliente3)); // false
    }


    [Fact]
    public void DevePermitirDescontoSeForEstudanteOuMenorDeIdadeUsandoRegraOU()
    {
        // Criar a expressão: idade < 19 AND tem carteira estudante
        IExpressao regra = new OU(new TemIdadeMenorQue19(), new PossuiCarteiraEstudante());

        // Teste 1
        var cliente1 = new Contexto { Idade = 30, TemCarteirinhaDaFaculdade = true };
        Console.WriteLine("Cliente 1 tem desconto? " + regra.Interpretar(cliente1)); // true

        // Teste 2
        var cliente2 = new Contexto { Idade = 12, TemCarteirinhaDaFaculdade = true };
        Console.WriteLine("Cliente 2 tem desconto? " + regra.Interpretar(cliente2)); // true

        // Teste 3
        var cliente3 = new Contexto { Idade = 28, TemCarteirinhaDaFaculdade = false };
        Console.WriteLine("Cliente 3 aprovado? " + regra.Interpretar(cliente3)); // false
    }
}