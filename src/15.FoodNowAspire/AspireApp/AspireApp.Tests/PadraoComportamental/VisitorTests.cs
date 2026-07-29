namespace AspireApp.Tests.PadraoComportamental.Visitor;

using AspireApp.Model.PadraoComportamental.Visitor;
public class VisitorTests
{
    [Fact]
    public void DeveGerarRelatorioDeAcordoComTipoLanche()
    {
        // Instanciando pedidos
        IPedido happyMeal = new HappyMeal { Descricao = "Hambúguer de Frango para Crianca", Brinquedo = "Boneca" };
        IPedido pedidoNormal = new PedidoNormal { Descricao = "Hambúrguer para gordinho" };
        IPedido pedidoVegano = new PedidoVegano { Descricao = "Hambúrguer de Tofú" };

        // Criando o visitante
        IVisitor fatura = new FaturaSimplificada();

        // Aplicando o visitante
        happyMeal.Encomendar(fatura);
        pedidoNormal.Encomendar(fatura);
        pedidoVegano.Encomendar(fatura);
    }
}