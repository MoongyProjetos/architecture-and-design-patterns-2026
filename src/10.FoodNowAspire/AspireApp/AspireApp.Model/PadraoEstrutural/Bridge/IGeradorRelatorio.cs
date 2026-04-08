namespace AspireApp.Model.PadraoEstrutural.Bridge;

public interface IGeradorRelatorio
{
    void Gerar(string content, string caminho);
}