namespace AspireApp.Model.PadraoComportamental.Mediator;

public interface IMediator
{
    void EnviarMensagem(string mensagem, Departamento origem);
}