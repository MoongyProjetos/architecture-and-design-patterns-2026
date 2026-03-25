namespace AspireApp.Tests.PadraoEstrutural;

using AspireApp.Model.PadraoEstrutural.Bridge;
public class BridgeTests
{
    [Fact]
    public void DeveSerCapazDeGerarUmRelatorioEmFormatoPDF()
    {
        IGeradorRelatorio formato = new GeradorPdf();
        CompraRestauranteRelatorio relatorio = new CompraRestauranteRelatorio(formato);

        // Act
        var exception = Record.Exception(relatorio.Gerar);

        // Assert
        Assert.Null(exception);
    }


    [Fact]
    public void DeveSerCapazDeGerarUmRelatorioEmFormatoWord()
    {
        IGeradorRelatorio formato = new GeradorWord();
        CompraRestauranteRelatorio relatorio = new CompraRestauranteRelatorio(formato);

        // Act
        var exception = Record.Exception(relatorio.Gerar);

        // Assert
        Assert.Null(exception);
    }


    [Fact]
    public void DeveSerCapazDeGerarUmRelatorioEmFormatoTxt()
    {
        IGeradorRelatorio formato = new GeradorTxt();
        CompraRestauranteRelatorio relatorio = new CompraRestauranteRelatorio(formato);

        // Act
        var exception = Record.Exception(relatorio.Gerar);

        // Assert
        Assert.Null(exception);
    }


    [Theory]
    [InlineData(typeof(GeradorPdf))]
    [InlineData(typeof(GeradorWord))]
    [InlineData(typeof(GeradorTxt))]
    public void DeveSerCapazDeGerarUmRelatorioEmDiferentesFormatos(Type tipoGerador)
    {
        // Arrange
        IGeradorRelatorio formato = (IGeradorRelatorio)Activator.CreateInstance(tipoGerador)!;
        var relatorio = new CompraRestauranteRelatorio(formato);

        // Act
        var exception = Record.Exception(relatorio.Gerar);

        // Assert
        Assert.Null(exception);
    }
}