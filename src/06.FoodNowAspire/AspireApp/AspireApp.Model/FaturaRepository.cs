namespace AspireApp.Model;

public class FaturaRepository : IRepository
{
    public void Save()
    {
        Console.WriteLine("Save to database");
    }
}