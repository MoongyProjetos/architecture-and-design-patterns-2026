namespace FoodNow.Logica;

public class Fatura : IFaturacao
{
    public void Imprimir()
    {
        System.Console.WriteLine("Fatura Impressa");
    }
}