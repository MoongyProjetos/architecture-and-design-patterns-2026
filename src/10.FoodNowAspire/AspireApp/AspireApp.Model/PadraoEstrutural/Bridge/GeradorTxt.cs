namespace AspireApp.Model.PadraoEstrutural.Bridge;

// Implementações
public class GeradorTxt : IGeradorRelatorio
{
    public void Gerar(string content, string caminho)
    {
        var fileName = Guid.NewGuid().ToString() + ".txt";
        File.AppendAllText(caminho + fileName, content);
    }
}