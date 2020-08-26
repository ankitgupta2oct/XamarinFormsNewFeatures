using System.Threading.Tasks;
using Xamarin.Forms;

using Version_4_8.Views;
using System.Windows.Input;

namespace Version_4_8.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ICommand GradientsAndBrushesCommand { get; }
        public ICommand DragAndDropCommand { get; }
        public ICommand FlyoutBackdropColorCommand { get; }

        public ItemsViewModel()
        {
            GradientsAndBrushesCommand = new Command(async () => await OnGradientsAndBrushesCommand().ConfigureAwait(false));
            DragAndDropCommand = new Command(async () => await OnDragAndDropCommand().ConfigureAwait(false));
            FlyoutBackdropColorCommand = new Command(OnFlyoutBackdropColorCommand);
        }

        private Task OnDragAndDropCommand()
        {
            return Application.Current.MainPage.Navigation.PushAsync(new DragAndDropPage());
        }

        private Task OnGradientsAndBrushesCommand()
        {
            return Application.Current.MainPage.Navigation.PushAsync(new GradientsAndBrushesPage());
        }

        private void OnFlyoutBackdropColorCommand()
        {
            Shell.Current.FlyoutIsPresented = true;
        }
    }
}