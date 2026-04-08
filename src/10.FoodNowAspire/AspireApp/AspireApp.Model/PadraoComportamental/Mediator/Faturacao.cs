namespace AspireApp.Model.PadraoComportamental.Mediator;

public class Faturacao : Departamento
{
    public Faturacao(IMediator m) : base(m) { }
    public override void Receber(string mensagem) => Console.WriteLine("Faturacao recebeu: " + mensagem);
}