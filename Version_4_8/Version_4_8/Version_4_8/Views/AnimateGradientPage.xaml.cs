using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Version_4_8.Views
{
    public partial class AnimateGradientPage : ContentPage
    {
        public AnimateGradientPage()
        {
            InitializeComponent();
            Task.Run(AnimateBackground);
        }

        private async Task AnimateBackground()
        {
            Action<double> forward = input => bdGradient.AnchorY = input;
            Action<double> backward = input => bdGradient.AnchorY = input;

            while (true)
            {
                bdGradient.Animate(name: "forward", callback: forward, start: 0, end: 1, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bdGradient.Animate(name: "backward", callback: backward, start: 1, end: 0, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
            }
        }
    }
}