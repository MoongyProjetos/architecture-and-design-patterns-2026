namespace AspireApp.Model.PadraoEstrutural.Flywheight;

public class Ingrediente {
    public static Guid Id => Guid.NewGuid();
    public string Nome { get; }
    public string ValorNutricional {get;set;}
    public string Tipo {get;set;}
    public Ingrediente(string nome) => Nome = nome;
}