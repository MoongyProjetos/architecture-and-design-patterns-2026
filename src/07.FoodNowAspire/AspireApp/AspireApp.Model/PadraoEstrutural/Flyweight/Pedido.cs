namespace AspireApp.Model.PadraoEstrutural.Flywheight;

public class Pedido {
    public string Cliente { get; }
    public Ingrediente Ingrediente { get; }

    public Pedido(string cliente, Ingrediente ingrediente) {
        Cliente = cliente;
        Ingrediente = ingrediente;
    }

    public void Exibir() => Console.WriteLine($"{Cliente} pediu algo com {Ingrediente.Nome}");
}