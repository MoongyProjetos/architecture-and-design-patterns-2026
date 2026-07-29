namespace AspireApp.Model.PadraoComportamental.Memento;

public class MementoPedido
{
    public string NomeCliente { get; set; }
    public string TipoDeRefeicao { get; set; }

    public MementoPedido(string nomecliente, string tiporefeicao)
    {
        NomeCliente = nomecliente;
        TipoDeRefeicao = tiporefeicao;
    }    
}