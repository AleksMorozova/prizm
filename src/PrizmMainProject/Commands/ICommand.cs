namespace Prizm.Main.Commands
{
    public delegate void RefreshVisualStateEventHandler();

    public interface ICommand
    {
        void Execute();

        bool CanExecute();

        bool Validate();

        event RefreshVisualStateEventHandler RefreshVisualStateEvent;
    }
}