using Logger.Abstract;
namespace Logger.Concrete.Commands;
public class LoadCommand : ICommand
{
    public Database Database { get; }
    public LoadCommand(Database database)
    {
        Database = database;
    }
    public void Execute()
    {
        Console.WriteLine("Executing load command...");
        Database.Delete();
    }
    public void Undo()
    {
        Console.WriteLine("Undo load command...");
        Database.Write();
    }
}