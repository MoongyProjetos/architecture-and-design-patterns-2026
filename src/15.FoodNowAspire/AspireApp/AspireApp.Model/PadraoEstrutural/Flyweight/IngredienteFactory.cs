namespace AspireApp.Model.PadraoEstrutural.Flywheight;

public class IngredienteFactory {
    private readonly Dictionary<string, Ingrediente> _cache = [];

    public Ingrediente GetIngrediente(string nome) {
        if (!_cache.ContainsKey(nome))
        {
            _cache[nome] = new Ingrediente(nome);
        }            

        return _cache[nome];
    }
}