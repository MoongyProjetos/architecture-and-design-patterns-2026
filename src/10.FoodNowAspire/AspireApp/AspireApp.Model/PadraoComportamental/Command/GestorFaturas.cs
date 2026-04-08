namespace AspireApp.Model.PadraoComportamental.Command;

//A responsabilidade dessa clase é receber a cadeia de comandos e efetivamente executar alguma coisa
// Receiver
public class GestorFaturas
{
    public void Emitir(string numero)
    {
        Console.WriteLine($"Fatura {numero} emitida com sucesso.");
    }

    public void Cancelar(string numero)
    {
        Console.WriteLine($"Fatura {numero} cancelada.");
    }

    public void Notificar(string numero)
    {
        Console.WriteLine($"Fatura {numero} notificada.");
    }
}