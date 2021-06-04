using System.ComponentModel;
using ToCom.ViewModels;
using Xamarin.Forms;

namespace ToCom.Views
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