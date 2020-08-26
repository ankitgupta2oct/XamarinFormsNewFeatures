using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Version_4_8.Views;
using Xamarin.Forms;

namespace Version_4_8.ViewModels
{
    public class GradientsAndBrushesViewModel : BaseViewModel
    {
        public ICommand AnimateGradientCommand { get; }

        public GradientsAndBrushesViewModel()
        {
            AnimateGradientCommand = new Command(async () => await OnAnimateGradientCommand().ConfigureAwait(false));
        }

        private Task OnAnimateGradientCommand()
        {
            return Application.Current.MainPage.Navigation.PushAsync(new AnimateGradientPage());
        }
    }
}
