using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Version_4_8.Views;

namespace Version_4_8
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            Device.SetFlags(new[] { "Brush_Experimental", "DragAndDrop_Experimental" });

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
