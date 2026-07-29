namespace AspireApp.Model.PadraoComportamental.Mediator;

public class Entrega : Departamento
{
    public Entrega(IMediator m) : base(m) { }
    public override void Receber(string mensagem) => Console.WriteLine("Entrega recebeu: " + mensagem);
}