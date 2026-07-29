namespace AspireApp.Model.PadraoComportamental.Mediator;

public class Caixa : Departamento
{
    public Caixa(IMediator m) : base(m) { }
    public void Enviar(string msg) => _mediator.EnviarMensagem(msg, this);
    public override void Receber(string mensagem) => Console.WriteLine("Avaliação recebeu: " + mensagem);
}