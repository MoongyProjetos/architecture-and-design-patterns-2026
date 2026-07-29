namespace AspireApp.Tests.PadraoComportamental.ChainOfResponsability;

using AspireApp.Model.PadraoComportamental.ChainOfResponsability;
public class CommandTests
{
    [Fact]
    public void DeveEscalarOPedidoDeAcordoComOvalorDoMesmo()
    {
        // Montando a cadeia de responsabilidade
        var atendente = new Atendente();
        var gerente = new Gerente();
        var diretor = new Diretor();

        atendente.DefinirProximo(gerente);
        gerente.DefinirProximo(diretor);

        // Casos de teste
        var pedido1 = new Pedido("Lanche da escola", 100, new List<string>());
        var pedido2 = new Pedido("Festa da Empresa Pequena", 10000, new List<string>());
        var pedido3 = new Pedido("Festa de Fim de Ano da Multinacional", 50000, new List<string>());
        var pedido4 = new Pedido("Buffet para o encontro dos líderes da ONU", 500000, new List<string>());


        atendente.Aprovar(pedido1);
        atendente.Aprovar(pedido2);
        atendente.Aprovar(pedido3);
        atendente.Aprovar(pedido4);
    }
}