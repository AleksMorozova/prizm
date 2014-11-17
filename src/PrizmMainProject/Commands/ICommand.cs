namespace PrizmMain.Commands
{
    public interface ICommand
    {
        void Execute();

        bool CanExecute();
    }
}