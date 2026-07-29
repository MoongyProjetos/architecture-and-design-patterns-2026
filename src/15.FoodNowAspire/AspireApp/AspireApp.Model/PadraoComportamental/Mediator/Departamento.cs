namespace AspireApp.Model.PadraoComportamental.Mediator;

public abstract class Departamento
{
    protected IMediator _mediator;

    protected Departamento(IMediator mediator) => _mediator = mediator;
    public abstract void Receber(string mensagem);
}