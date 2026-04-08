namespace AspireApp.Model.PadraoComportamental.Command;

public class CancelarFaturaCommand : IComandoFatura
{
    private readonly GestorFaturas _gestor;
    private readonly string _numero;

    public CancelarFaturaCommand(GestorFaturas gestor, string numero)
    {
        _gestor = gestor;
        _numero = numero;
    }

    public void Executar()
    {
        _gestor.Cancelar(_numero);
    }
}