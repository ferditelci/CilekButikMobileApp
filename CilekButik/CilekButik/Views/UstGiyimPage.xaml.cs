using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CilekButik.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UstGiyimPage : ContentView
    {
        public UstGiyimPage()
        {
            InitializeComponent();
        }

        private async void UstGiyimlerSayfasiAc(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UstGiyimPage());
        }
    }
}