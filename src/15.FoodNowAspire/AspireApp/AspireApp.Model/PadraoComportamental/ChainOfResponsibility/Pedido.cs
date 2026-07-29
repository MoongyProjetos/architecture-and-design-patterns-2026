namespace AspireApp.Model.PadraoComportamental.ChainOfResponsability;

public class Pedido
{
    public string Descricao { get; set; }

    public decimal Valor { get; set; }
    public List<string> Itens { get; set; }

    public Pedido(string descricao, decimal valor, List<string> itens)
    {
        Descricao = descricao;
        Valor = valor;
        Itens = itens;
    }
}