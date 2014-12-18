namespace Prizm.Main.Commands
{
    public interface ICommand
    {
        void Execute();

        bool CanExecute();

        bool IsExecutable { get; set; }
    }
}