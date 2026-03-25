namespace AspireApp.Tests.PadraoEstrutural;

using AspireApp.Model.PadraoEstrutural.Adapter;
public class AdapterTests
{
    [Fact]
    public void DeveSerCapazDeConsultarUmaAPIExternaERetornarDadosNoFormatoDoRestaurante()
    {
        // Given
        RestauranteDetalhe restaurante  = new RestauranteDetalhe();
        
        // When
        ExternalRestaurantApi api = new ExternalRestaurantApi();//Simulacao chamada api
        RestauranteAdapter adapter = new RestauranteAdapter(api);
        restaurante = adapter.ObterRestaurante(Guid.NewGuid()); //a implemtação do Adapter esconde detalhes da conversão de dados de aplicativos ou apis para o formato que nossa aplicação conhece 
        
        // Then
        Assert.NotNull(restaurante);
        Assert.Equal("1", restaurante.Id);
        Assert.Equal("Pizza Place", restaurante.Nome);
        Assert.False(string.IsNullOrWhiteSpace(restaurante.Endereco));
    }
}