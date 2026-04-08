namespace AspireApp.Tests.PadraoEstrutural.Composite;

using AspireApp.Model.PadraoEstrutural.Composite;
public class CompositeTests
{
    [Fact]
    public void DadoUmaQuantidadeDeItensSimplesOSomatorioDoValorDosItensDeveSerIgual()
    {
        // Given        
        var item = new ItemSimples(10);            
   
        // Then
        Assert.Equal(10, item.ObterPreco());
    }

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