namespace AspireApp.Model.PadraoComportamental.Command;

public class NotificarFaturaCommand : IComandoFatura
{
    private readonly GestorFaturas _gestor;
    private readonly string _numero;

    public NotificarFaturaCommand(GestorFaturas gestor, string numero)
    {
        _gestor = gestor;
        _numero = numero;
    }

    public void Executar()
    {
        _gestor.Notificar(_numero);
    }
}