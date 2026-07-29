namespace AspireApp.Model.PadraoComportamental.TemplateMethod;

public class VeganFood : Pedido
{
    protected override void PrepararSanduiche() => Console.WriteLine("Sanduiche de Tofu sendo descongelado");
    protected override void PrepararBebida()  => Console.WriteLine("Pegando Água da torneira");
    protected  override void PreparaExtra() => Console.WriteLine("Colocando mais verduras ainda");

    protected override void EmitirFatura()
    {
        base.EmitirFatura();
        Console.WriteLine("Fatura VEGAN com desconto emitida");
    }
}