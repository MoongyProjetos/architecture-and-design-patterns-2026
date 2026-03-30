namespace AspireApp.Tests.PadraoEstrutural.Flywheight;

using AspireApp.Model.PadraoEstrutural.Flywheight;
public class FlywheightTests
{
    [Fact]
    public void ExemploUsoFlywheight()
    {
        // Given        
        var ingredientesFactory = new IngredienteFactory(); 

        var cebola = ingredientesFactory.GetIngrediente("cebola");
        var cebolinha = ingredientesFactory.GetIngrediente("cebola");
   
        // Then        
        Assert.Equivalent(cebola, cebolinha);
    }
}
