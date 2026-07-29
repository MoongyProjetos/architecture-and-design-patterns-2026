namespace AspireApp.Model.PadraoEstrutural.Bridge;


// Refined Abstraction
public class CompraRestauranteRelatorio : RelatorioCompra {
    protected IGeradorRelatorio _exporter;
    public CompraRestauranteRelatorio(IGeradorRelatorio exporter) : base(exporter)
    {
        _exporter = exporter;
    }

    public override void Gerar() {
        var content = "Relatório de pedidos por restaurante";
        _exporter.Gerar(content, "c:\\temp\\");
    }
}