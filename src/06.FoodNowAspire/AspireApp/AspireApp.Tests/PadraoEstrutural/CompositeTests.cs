namespace AspireApp.Tests.PadraoEstrutural;

using AspireApp.Model.PadraoEstrutural.Composite;
public class CompositeTests
{
    [Fact]
    public void DadoUmaQuantidadeDeItensSimplesOSomatorioDoValorDosItensDeveSerIgualAoValorDoCombo()
    {
        // Given        
        var combo = new ItemCombo();
            
        // When
        combo.Adicionar(new ItemSimples(10)); // burger
        combo.Adicionar(new ItemSimples(5));  // drink
    
        // Then
        Assert.Equal(15, combo.ObterPreco());
    }
}