namespace AspireApp.Services.Pagamento;


/// <summary>
/// O factoryMethod permite Definir uma interface para criar um objeto, mas deixar as subclasses decidirem qual classe instanciar.
/// </summary>
public abstract class PagamentoFactoryMethod
{
    public abstract void Processar();
}