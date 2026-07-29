using AspireApp.Model.PadraoEstrutural.Adapter.Dto;

namespace AspireApp.Model.PadraoEstrutural.Adapter; 

// Adapter
public class RestauranteAdapter : IRestauranteService {
    private readonly ExternalRestaurantApi _api;

    public RestauranteAdapter(ExternalRestaurantApi api) {
        _api = api;
    }

    //O ponto do adapter, é que ele esconde ou encapsula a complexidade de outros sistemas.
    //Nesse caso, escolhemos esconder uma implementação de API Rest, mas poderíamos ter chamadas mais complexas
    // exemplo, o scrapping da segurança social direta.
    public RestauranteDetalhe ObterRestaurante(Guid id) {
        var json = _api.FetchRestaurantData(id.ToString());
        var options = new System.Text.Json.JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var restauranteApiDto = System.Text.Json.JsonSerializer.Deserialize<RestaurantApiDto>(json, options);

        var restauranteDetalhe = new RestauranteDetalhe
        {
            Id = restauranteApiDto?.Id.ToString(),
            Nome = restauranteApiDto?.Name,
            Endereco = $"{restauranteApiDto?.Address}, Telefone: {restauranteApiDto?.PhoneNumber}" 
        };

        return restauranteDetalhe;
    }
}