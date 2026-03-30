using RasterEdge.XDoc.Word;

namespace AspireApp.Model.PadraoEstrutural.Bridge;

// Implementações
public class GeradorWord : IGeradorRelatorio {
    // public void Gerar(string content) => Console.WriteLine($"Exportando PDF: {content}");

    public void Gerar(string content, string caminho)
    {
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(content);
        DOCXDocument doc = new DOCXDocument(bytes);
        var fileName = Guid.NewGuid().ToString() + ".docx";
        doc.Save(caminho + fileName);
    }
}