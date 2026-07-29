namespace AspireApp.Model.PadraoEstrutural.Decorator;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class MolhoAttribute : Attribute
{
    public string Tipo {get; }

    public MolhoAttribute(string tipo)
    {
        Tipo = tipo;
        Console.WriteLine("Oi, estou usando o Atributo e adicionando comportamento ao seu objeto");
    }

    public MolhoAttribute()
    {
        Console.WriteLine("Oi, estou usando o Atributo e adicionando comportamento ao seu objeto");
    }
}