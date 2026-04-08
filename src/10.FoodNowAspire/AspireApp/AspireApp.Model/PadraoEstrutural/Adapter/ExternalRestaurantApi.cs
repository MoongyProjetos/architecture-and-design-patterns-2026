namespace AspireApp.Model.PadraoEstrutural.Adapter; 

// API externa (formato diferente) => Providenciada pelo iFood, pelo Glovo...
public class ExternalRestaurantApi {
    public string FetchRestaurantData(string id) {
        return "{ \"id\": 1, \"name\": \"Pizza Place\", \"address\": \"Lisbon Street\", \"PhoneNumber\": \"123 456 789\" }";
    }
}