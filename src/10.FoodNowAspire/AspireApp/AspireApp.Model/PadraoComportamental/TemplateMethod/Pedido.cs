namespace AspireApp.Model.PadraoComportamental.TemplateMethod;

public abstract class Pedido
{
    public void MontarMenu()
    {
        PrepararSanduiche();
        PrepararBebida();
        PreparaExtra();
        EmitirFatura();
    }

    protected abstract void PrepararSanduiche();
    protected abstract void PrepararBebida();
    protected abstract void PreparaExtra();

    protected virtual void EmitirFatura()
    {
        Console.WriteLine("Fatura Emitida com sucesso");
    }
}