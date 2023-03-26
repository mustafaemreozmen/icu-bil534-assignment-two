using Logger.Abstract;
namespace Logger.Concrete;
public class LogHelper
{
    public Dictionary<string, ICommand> RestoreCommands { get; set; }
    public Dictionary<string, ICommand> LoadCommands { get; set; }
    public Dictionary<string, ICommand> ClearCommands { get; set; }
    public Stack<ICommand> CommandHistory { get; set; }
    public LogHelper()
    {
        RestoreCommands = new Dictionary<string, ICommand>();
        LoadCommands = new Dictionary<string, ICommand>();
        ClearCommands = new Dictionary<string, ICommand>();
        CommandHistory = new Stack<ICommand>();
    }

    public void Load(string key)
    {
        LoadCommands[key].Execute();
        CommandHistory.Push(LoadCommands[key]);
    }

    public void Restore(string key)
    {
        RestoreCommands[key].Execute();
        CommandHistory.Push(RestoreCommands[key]);
    }

    public void Clear(string key)
    {
        ClearCommands[key].Execute();
        CommandHistory.Push(ClearCommands[key]);
    }

    public void UndoAction()
    {
        var lastCommand = CommandHistory.Pop();
        lastCommand.Undo();
    }
}