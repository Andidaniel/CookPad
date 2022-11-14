using CookPad.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CookPad.Views
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