namespace Logger.Abstract;

public interface ICommand
{
    public void Execute();
    public void Undo();
}