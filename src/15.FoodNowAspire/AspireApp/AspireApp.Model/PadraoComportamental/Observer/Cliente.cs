namespace AspireApp.Model.PadraoComportamental.Observer;

// Observador concreto, ou seja, o objeto capaz de executar alguma coisa
public class Cliente : IClienteObserver
{
    public string Nome { get; }

    public Cliente(string nome)
    {
        Nome = nome;
    }

    public void Notificar(string mensagem)
    {
        Console.WriteLine($"{Nome} recebeu notificação: {mensagem}");
    }
}