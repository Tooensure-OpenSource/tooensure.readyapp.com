using ReadyApp.UI.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ReadyApp.UI.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}