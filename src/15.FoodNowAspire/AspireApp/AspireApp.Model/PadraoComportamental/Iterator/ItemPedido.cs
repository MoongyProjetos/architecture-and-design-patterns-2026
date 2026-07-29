namespace AspireApp.Model.PadraoComportamental.Iterator;

public class ItemPedido
{
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public string? Observacao { get; set; }
    public decimal Valor { get; set; }

    public void FalarNome() => Console.WriteLine($"O nome do Item é {Nome}");
}