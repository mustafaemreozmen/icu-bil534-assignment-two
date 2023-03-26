using Logger.Abstract;
namespace Logger.Concrete.Commands;
public class ClearCommand : ICommand
{
    public Database Database { get; }
    public ClearCommand(Database database)
    {
        Database = database;
    }
    public void Execute()
    {
        Console.WriteLine("Executing clear command...");
        while (Database.LineCount != 0)
        {
            Database.Delete();
        }
    }
    public void Undo()
    {
        Console.WriteLine("Undo clear command...");
        Database.Write();
    }
}