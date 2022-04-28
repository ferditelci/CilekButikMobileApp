using CilekButik.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CilekButik.Views
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