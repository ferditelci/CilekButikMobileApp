using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CilekButik.ViewModels
{
    public class CilekButikLogoViewModel : BaseViewModel
    {
        public CilekButikLogoViewModel()
        {
            Logo = "CilekButikLogo";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}