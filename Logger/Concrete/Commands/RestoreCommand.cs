using Logger.Abstract;
namespace Logger.Concrete.Commands;
public class RestoreCommand : ICommand
{
    public Database Database { get; }

    public RestoreCommand(Database database)
    {
        Database = database;
    }
    public void Execute()
    {
        Console.WriteLine("Executing restore command...");
        Database.Write();
    }
    public void Undo()
    {
        Console.WriteLine("Undo restore command...");
        Database.Delete();
    }
}