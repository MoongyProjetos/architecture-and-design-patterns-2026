namespace AspireApp.Tests.PadraoComportamental.Command;

using AspireApp.Model.PadraoComportamental.Command;
public class CommandTests
{
    [Fact]
    public void DeveChamarOComandoCorretoComBaseNoTipoICommandCorreto()
    {
        var gestor = new GestorFaturas();
        var emitirCmd = new EmitirFaturaCommand(gestor, "FAT123456");
        var cancelarCmd = new CancelarFaturaCommand(gestor, "FAT654321");
        var notificarCmd = new NotificarFaturaCommand(gestor, "FAT654321");

        var central = new CentralComandos();
        central.ExecutarComando(emitirCmd);
        central.ExecutarComando(cancelarCmd);
        central.ExecutarComando(notificarCmd);
    }
}