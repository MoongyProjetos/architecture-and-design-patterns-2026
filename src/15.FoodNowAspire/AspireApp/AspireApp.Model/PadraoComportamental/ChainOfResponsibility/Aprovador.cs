namespace AspireApp.Model.PadraoComportamental.ChainOfResponsability;

//O padrao Chain of Responsability é utilizado quando precisamos escalar um objeto entre diferentes etapas
public abstract class Aprovador {
    protected Aprovador Proximo;
    public void DefinirProximo(Aprovador proximo) => Proximo = proximo;
    public abstract void Aprovar(Pedido pedido);
}