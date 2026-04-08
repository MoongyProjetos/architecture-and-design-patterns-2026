namespace AspireApp.Model.PadraoEstrutural.Facade.Subsystems;

public class PagamentoService {
    public void Processar(decimal valor) => Console.WriteLine($"Pagamento de {valor} processado");
}