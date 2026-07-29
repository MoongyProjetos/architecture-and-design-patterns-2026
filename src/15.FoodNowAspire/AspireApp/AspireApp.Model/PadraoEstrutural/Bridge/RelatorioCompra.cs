namespace AspireApp.Model.PadraoEstrutural.Bridge;

// Abstraction
public abstract class RelatorioCompra {
    protected IGeradorRelatorio _gerador;

    protected RelatorioCompra(IGeradorRelatorio gerador) {
        _gerador = gerador;
    }

    public abstract void Gerar();
}