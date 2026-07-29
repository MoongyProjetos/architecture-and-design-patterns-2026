using AspireApp.Model.PadraoComportamental.Mediator;

namespace AspireApp.Tests.PadraoComportamental.Mediator;

public class ObserverTests
{
    [Fact]
    public void DeveNotificarDestinoComBaseNaOrigemUsandoMediator()
    {
        //Criacao Mediator
        var mediator = new CentralMediator();

        //Criacao departamentos
        var caixa = new Caixa(mediator);
        var faturacao = new Faturacao(mediator);
        var entrega = new Entrega(mediator);

        // Registrando os departamentos no mediador
        mediator.RegistrarDepartamento(caixa);
        mediator.RegistrarDepartamento(faturacao);
        mediator.RegistrarDepartamento(entrega);


        // Enviando mensagens entre os departamentos
        caixa.Enviar("Pedido de Hambúrguer");
        entrega.Receber("Pacote com lanmche para entrega");
    }
}