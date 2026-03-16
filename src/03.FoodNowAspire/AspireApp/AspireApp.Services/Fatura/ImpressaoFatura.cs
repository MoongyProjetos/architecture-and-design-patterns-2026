namespace AspireApp.Services.Fatura;

public static class ImpressaoFatura
{
    public static void Imprimir(Fatura fatura)
    {
        Console.WriteLine($"Valor da Fatura: {fatura}");
    }
}

