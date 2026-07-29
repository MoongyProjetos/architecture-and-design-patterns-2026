namespace AspireApp.Model.PadraoComportamental.TemplateMethod;

public class HappyMeal : Pedido
{
    protected override void PrepararSanduiche() => Console.WriteLine("Sanduiche de Crianca sendo preparado");
    protected override void PrepararBebida()  => Console.WriteLine("Bongo sendo preparado");
    protected  override void PreparaExtra() => Console.WriteLine("Separando brinquedo e adicionando cenouras");
}