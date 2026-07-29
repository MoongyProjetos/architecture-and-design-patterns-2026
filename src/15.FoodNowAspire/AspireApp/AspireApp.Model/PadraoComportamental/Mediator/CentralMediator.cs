namespace AspireApp.Model.PadraoComportamental.Mediator;

public class CentralMediator : IMediator
{
    public Caixa _caixa { get; set; }
    public Entrega _entrega { get; set; }
    public Faturacao _faturacao { get; set; }


    public void RegistrarDepartamento(Departamento departamento)
    {
        if (departamento is Caixa caixa)
        {
            _caixa = caixa;
        }
        else if (departamento is Entrega entrega)
        {
            _entrega = entrega;
        }
        else if (departamento is Faturacao faturacao)
        {
            _faturacao = faturacao;
        }
    }

    public void EnviarMensagem(string mensagem, Departamento origem)
    {
        if (origem == _caixa)
        {
            _entrega.Receber(mensagem);
        }            
        if (origem == _entrega)
        {
            _faturacao.Receber(mensagem);
        }            
        else
        {
            _caixa.Receber(mensagem);
        }            
    }
}