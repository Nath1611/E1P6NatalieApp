using E1P6NatalieApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace E1P6NatalieApp.Views
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