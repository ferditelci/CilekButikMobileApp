using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;

namespace CilekButik.Views
{
    public partial class AboutPage : ContentPage
    {

        public AboutPage()
        {
            InitializeComponent();
            BindingContext = this;
            Vegetables = new ObservableCollection<Vegetable>
{
new Vegetable{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750d5807ee3-61916.jpeg",Name="Corn"},
new Vegetable{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750d20589c7-520610.jpeg",Name="Carrot"},
new Vegetable{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750ce4d623e-133837.jpeg",Name="Pepper"},
new Vegetable{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750c968de71-912530.jpeg",Name="Tomato"},
new Vegetable{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750c968de71-912530.jpeg",Name="Lemon"}
};
            Fruits = new ObservableCollection<Fruit>
{
new Fruit{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750bb2b3dcd-626818.jpeg",Name="Apple"},
new Fruit{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750d5807ee3-61916.jpeg",Name="Banana"},
new Fruit{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750c968de71-912530.jpeg",Name="Mango"},
new Fruit{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750c968de71-912530.jpeg",Name="Orange"},
new Fruit{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750c268d53d-988604.jpeg",Name="Strawberry"}
};
        }
        public class Vegetable
        {
            public ImageSource Image { get; set; }
            public String Name { get; set; }
        }
        private ObservableCollection<Vegetable> vegetables;
        public ObservableCollection<Vegetable> Vegetables
        {
            get { return vegetables; }
            set
            {
                vegetables = value;
                OnPropertyChanged();
            }
        }
        public class Fruit
        {
            public ImageSource Image { get; set; }
            public String Name { get; set; }
        }
        private ObservableCollection<Fruit> fruits;
        public ObservableCollection<Fruit> Fruits
        {
            get { return fruits; }
            set
            {
                fruits = value;
                OnPropertyChanged();
            }
        }
    }
}