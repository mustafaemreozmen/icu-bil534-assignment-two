using Logger.Abstract;
namespace Logger.Concrete.Commands;
public class NoCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Not implemented execution function");
    }
    public void Undo()
    {
        Console.WriteLine("Not implemented undo function");
    }
}