using System.ComponentModel;
using Xamarin.Forms;
using Version_4_8.ViewModels;

namespace Version_4_8.Views
{
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = new ItemsViewModel();
        }
    }
}