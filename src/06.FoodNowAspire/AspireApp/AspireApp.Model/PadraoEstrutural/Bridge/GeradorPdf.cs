namespace AspireApp.Model.PadraoEstrutural.Bridge;

// Implementações
public class GeradorPdf : IGeradorRelatorio
{
    public void Gerar(string content, string caminho) => Console.WriteLine($"Exportando PDF: {content}, para pasta {caminho}");    
}