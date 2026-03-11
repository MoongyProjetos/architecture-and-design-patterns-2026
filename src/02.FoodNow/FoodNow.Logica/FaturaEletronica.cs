namespace FoodNow.Logica;

public class FaturaEletronica : IFaturacao
{
    public void Imprimir()
    {
        System.Console.WriteLine("Fatura Eletronica");
    }
}