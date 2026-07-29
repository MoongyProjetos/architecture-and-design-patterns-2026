namespace AspireApp.Model.PadraoComportamental.Command;

// Invoker
public class CentralComandos
{
    public void ExecutarComando(IComandoFatura comando)
    {
        comando.Executar();
    }
}