namespace AspireApp.Model.PadraoComportamental.Command;

// Comandos concretos
public class EmitirFaturaCommand : IComandoFatura
{
    private readonly GestorFaturas _gestor;
    private readonly string _numero;

    public EmitirFaturaCommand(GestorFaturas gestor, string numero)
    {
        _gestor = gestor;
        _numero = numero;
    }

    public void Executar()
    {
        _gestor.Emitir(_numero);
    }
}