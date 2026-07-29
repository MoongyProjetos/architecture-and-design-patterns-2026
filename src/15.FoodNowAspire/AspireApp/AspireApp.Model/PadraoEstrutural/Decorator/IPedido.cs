namespace AspireApp.Model.PadraoEstrutural.Decorator;

public interface IPedido
{
    string Descricao();
    decimal CalcularPreco();
}