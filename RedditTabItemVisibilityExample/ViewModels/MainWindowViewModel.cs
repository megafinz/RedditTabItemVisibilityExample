using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;

namespace RedditTabItemVisibilityExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ToggleMoreContentCommand = ReactiveCommand.Create(DoToggleMoreContent);
        }
        public ReactiveCommand<Unit, Unit> ToggleMoreContentCommand { get; }

        [Reactive] public bool HasMoreContent { get; private set; }

        private void DoToggleMoreContent()
        {
            HasMoreContent = !HasMoreContent;
        }
    }
}
