namespace Logger.Concrete;

public class Database
{
    public static int LineCount = 0;
    public string DatabaseType { get; }
    public Database(string databaseType)
    {
        DatabaseType = databaseType;
    }
    public void Delete()
    {

        Console.WriteLine($"{LineCount} Before Delete Current Line");
        Console.WriteLine($"{DatabaseType} Deleting...");
        LineCount = LineCount > 0 ? --LineCount : 0;
        Console.WriteLine($"{LineCount} After Delete Current Line");
    }

    public void Write()
    {
        Console.WriteLine($"{LineCount} Before Write Current Line");
        Console.WriteLine($"{DatabaseType} Writing...");
        LineCount++;
        Console.WriteLine($"{LineCount} After Write Current Line");

    }
}