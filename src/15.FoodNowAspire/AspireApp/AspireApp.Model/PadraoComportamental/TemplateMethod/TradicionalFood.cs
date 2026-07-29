namespace AspireApp.Model.PadraoComportamental.TemplateMethod;

public class TradicionalFood : Pedido
{
    protected override void PrepararSanduiche() => Console.WriteLine("Sanduiche de verdade sendo grelhado");
    protected override void PrepararBebida()  => Console.WriteLine("Aquela cerveja geladinha");
    protected  override void PreparaExtra() => Console.WriteLine("Mais bacons e salsicha pra estragar a dieta");
}