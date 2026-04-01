namespace AspireApp.Tests.PadraoEstrutural.Flywheight;

using AspireApp.Model.PadraoEstrutural.Flywheight;
public class FlywheightTests
{

    [Fact]
    public void GetIngrediente_MesmaChave_DeveRetornarMesmaInstancia()
    {
        // Arrange
        var factory = new IngredienteFactory();

        // Act
        var ingrediente1 = factory.GetIngrediente("cebola");
        var ingrediente2 = factory.GetIngrediente("cebola");

        // Assert
        Assert.Same(ingrediente1, ingrediente2);
    }

    [Fact]
    public void GetIngrediente_ChavesDiferentes_DevemRetornarInstanciasDiferentes()
    {
        // Arrange
        var factory = new IngredienteFactory();

        // Act
        var cebola = factory.GetIngrediente("cebola");
        var tomate = factory.GetIngrediente("tomate");

        // Assert
        Assert.NotSame(cebola, tomate);
    }

    [Fact]
    public void GetIngrediente_MesmaChave_DeveManterConsistenciaDeDados()
    {
        // Arrange
        var factory = new IngredienteFactory();

        // Act
        var ingrediente1 = factory.GetIngrediente("cebola");
        var ingrediente2 = factory.GetIngrediente("cebola");

        // Assert
        Assert.Equal(ingrediente1.Nome, ingrediente2.Nome);
    }

    [Fact]
    public void GetIngrediente_MultiplasChamadas_DeveReutilizarInstancias()
    {
        // Arrange
        var factory = new IngredienteFactory();

        // Act
        var instancias = Enumerable.Range(0, 100)
            .Select(_ => factory.GetIngrediente("cebola"))
            .ToList();

        // Assert
        Assert.All(instancias, i => Assert.Same(instancias[0], i));
    }


}
