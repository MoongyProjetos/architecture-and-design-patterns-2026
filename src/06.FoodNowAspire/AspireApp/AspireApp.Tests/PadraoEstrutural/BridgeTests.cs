namespace AspireApp.Tests.PadraoEstrutural;

using AspireApp.Model.PadraoEstrutural.Bridge;
public class BridgeTests
{
    [Fact]
    public void DeveSerCapazDeGerarUmRelatorioEmFormatoPDF()
    {
        IGeradorRelatorio formato = new GeradorPdf();
        CompraRestauranteRelatorio relatorio = new CompraRestauranteRelatorio(formato);
        relatorio.Gerar();
    }


    [Fact]
    public void DeveSerCapazDeGerarUmRelatorioEmFormatoWord()
    {
        IGeradorRelatorio formato = new GeradorWord();
        CompraRestauranteRelatorio relatorio = new CompraRestauranteRelatorio(formato);
        relatorio.Gerar();
    }


    [Fact]
    public void DeveSerCapazDeGerarUmRelatorioEmFormatoTxt()
    {
        IGeradorRelatorio formato = new GeradorTxt();
        CompraRestauranteRelatorio relatorio = new CompraRestauranteRelatorio(formato);
        relatorio.Gerar();
    }
}