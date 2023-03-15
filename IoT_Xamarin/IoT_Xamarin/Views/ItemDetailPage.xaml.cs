using IoT_Xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace IoT_Xamarin.Views
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