using AspireApp.Model.PadraoComportamental.TemplateMethod;

namespace AspireApp.Tests.PadraoComportamental.TemplateMethod;

public class TemplateMethodTests
{
    [Fact]
    public void DeveIterarEntreDiferentesTiposDePedidos()
    {
        Console.WriteLine("Exemplo de uso do Template Method:");

        // Criando o happy meal
        var happyMeal = new HappyMeal();
        happyMeal.MontarMenu();

        
        // Criando o vegan
        var vegan = new VeganFood();
        vegan.MontarMenu();
    }
}