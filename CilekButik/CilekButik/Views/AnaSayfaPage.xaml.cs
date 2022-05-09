using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;

namespace CilekButik.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnaSayfaPage : ContentPage
    {
        public AnaSayfaPage()
        {
            InitializeComponent();
            BindingContext = this;
            Urunler = new ObservableCollection<Urun>
            {
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750d5807ee3-61916.jpeg",Name="Lakers Oversize Tişört", Fiyat = "100.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750d20589c7-520610.jpeg",Name="Yeni Sezon Crop", Fiyat = "50.00 TL" , Kategori = "Crop", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750ce4d623e-133837.jpeg",Name="Logo Detay Şortlu Takım", Fiyat = "100.00 TL" , Kategori = "İkili takım", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750c968de71-912530.jpeg",Name="Oversize Kalıp Tişört", Fiyat = "90.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750c56e9c05-254966.jpeg",Name="Sırt Detay Oversize Tişört", Fiyat = "100.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750c268d53d-988604.jpeg",Name="Yeni Sezon Tişört", Fiyat = "65.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750be21ebc5-702843.jpeg",Name="Yeni Sezon Tişört", Fiyat = "65.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750bb2b3dcd-626818.jpeg",Name="Yeni Sezon Tişört", Fiyat = "65.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740b7a6da61-633224.jpeg",Name="Lakers Crop", Fiyat = "55.00 TL" , Kategori = "Crop", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740b4ada621-478122.jpeg",Name="Oversize Kalıp Tişört", Fiyat = "110.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740b1d2d5ca-507652.jpeg",Name="Yeni Sezon Tişört", Fiyat = "80.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740ad02f023-724136.jpeg",Name="Sırt Detay Tişört", Fiyat = "110.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740a99dee1e-250385.jpeg",Name="Logo Detay Tişört", Fiyat = "90.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740a4099964-687713.jpeg",Name="Sırt Detay Paraşüt Kumaş Ceket", Fiyat = "150.00 TL" , Kategori = "Ceket", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62710ed05f131-656051.jpg",Name="Yeni Sezon Tişört", Fiyat = "85.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/626c0f4fee72d-965589.jpeg",Name="Yüksek Bel Eşofman", Fiyat = "70.00 TL" , Kategori = "Eşofman", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/6227795e70a3f-433637.jpeg",Name="Complex Ceket", Fiyat = "150.00 TL" , Kategori = "Ceket", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/61fd11dae86b9-3739.jpeg",Name="Yeni Sezon Fermuarlı Elbise", Fiyat = "75.00 TL" , Kategori = "Elbiseler", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/61e805e9df42d-3672.jpeg",Name="Zincir Detay Kemer", Fiyat = "40.00 TL" , Kategori = "Aksesuar", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62347c4a427e1-96329.jpeg",Name="3iplik Eşofman Takım", Fiyat = "150.00 TL" , Kategori = "İkili takım", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/6228cccba58a0-917847.jpeg",Name="İkili Takım", Fiyat = "85.00 TL" , Kategori = "İkili takım", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/621f594b4cde5-3823.jpeg",Name="Yeni Sezon Eşofman Takım", Fiyat = "100.00 TL" , Kategori = "İkili takım", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/6026a49518aac-1911.jpg",Name="DERİ CEKET", Fiyat = "180.00 TL" , Kategori = "Ceket", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/61c1ef8c377b0-3563.jpeg",Name="NBA Kolej Ceket", Fiyat = "190.00 TL" , Kategori = "Ceket", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/6218dc3f2835e-3814.jpeg",Name="Oversize Kalıp Yelek", Fiyat = "160.00 TL" , Kategori = "Ceket", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/61eab4eaf2b1d-3692.jpeg",Name="Yeni Sezon Oversize Kalıp Gömlek", Fiyat = "100.00 TL" , Kategori = "Gömlek/Bluz", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/625063133639b-231057.jpeg",Name="Sırt Detay Oversize Kalıp Gömlek", Fiyat = "120.00 TL" , Kategori = "Gömlek/Bluz", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62442c5614ba7-666603.jpeg",Name="Kol Deri Nakış Yazı Gömlek", Fiyat = "125.00 TL" , Kategori = "Gömlek/Bluz", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/61e18daaa82d5-3666.jpeg",Name="Tül Crop", Fiyat = "45.00 TL" , Kategori = "Crop", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/6228cd02e0e5c-878967.jpeg",Name="Yeni Sezon Triko", Fiyat = "85.00 TL" , Kategori = "Kazak", Stok = 10},
            new Urun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/625062d40a5d2-303868.jpeg",Name="Sırt Detay Crop", Fiyat = "50.00 TL" , Kategori = "Crop", Stok = 10},
            };
            GununFirsatlari = new ObservableCollection<GununFirsati>
            {
            new GununFirsati{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750d5807ee3-61916.jpeg",Name="Lakers Oversize Tişört", Fiyat = "100.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new GununFirsati{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750d20589c7-520610.jpeg",Name="Yeni Sezon Crop", Fiyat = "50.00 TL" , Kategori = "Crop", Stok = 10},
            new GununFirsati{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750ce4d623e-133837.jpeg",Name="Logo Detay Şortlu Takım", Fiyat = "100.00 TL" , Kategori = "İkili takım", Stok = 10},
            new GununFirsati{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750c968de71-912530.jpeg",Name="Oversize Kalıp Tişört", Fiyat = "90.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new GununFirsati{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750c56e9c05-254966.jpeg",Name="Sırt Detay Oversize Tişört", Fiyat = "100.00 TL" , Kategori = "T-Shirt", Stok = 10},

            };
            CokSatanlar = new ObservableCollection<CokSatan>
            {
            new CokSatan{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750c268d53d-988604.jpeg",Name="Yeni Sezon Tişört", Fiyat = "65.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new CokSatan{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750be21ebc5-702843.jpeg",Name="Yeni Sezon Tişört", Fiyat = "65.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new CokSatan{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62750bb2b3dcd-626818.jpeg",Name="Yeni Sezon Tişört", Fiyat = "65.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new CokSatan{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740b7a6da61-633224.jpeg",Name="Lakers Crop", Fiyat = "55.00 TL" , Kategori = "Crop", Stok = 10},
            new CokSatan{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740b4ada621-478122.jpeg",Name="Oversize Kalıp Tişört", Fiyat = "110.00 TL" , Kategori = "T-Shirt", Stok = 10},

            };
            OneCikanUrunler = new ObservableCollection<OneCikanUrun>
            {
            new OneCikanUrun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740b1d2d5ca-507652.jpeg",Name="Yeni Sezon Tişört", Fiyat = "80.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new OneCikanUrun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740ad02f023-724136.jpeg",Name="Sırt Detay Tişört", Fiyat = "110.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new OneCikanUrun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740a99dee1e-250385.jpeg",Name="Logo Detay Tişört", Fiyat = "90.00 TL" , Kategori = "T-Shirt", Stok = 10},
            new OneCikanUrun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62740a4099964-687713.jpeg",Name="Sırt Detay Paraşüt Kumaş Ceket", Fiyat = "150.00 TL" , Kategori = "Ceket", Stok = 10},
            new OneCikanUrun{Image = "https://www.cilekbutik.net/cdn/1/300/500/images/urunler/62710ed05f131-656051.jpg",Name="Yeni Sezon Tişört", Fiyat = "85.00 TL" , Kategori = "T-Shirt", Stok = 10},

            };
        }
        public class Urun
        {
            public ImageSource Image { get; set; }
            public String Name { get; set; }
            public String Kategori { get; set; }
            public String Fiyat { get; set; }
            public int Stok { get; set; }
        }
        private ObservableCollection<Urun> urunler;
        public ObservableCollection<Urun> Urunler
        {
            get { return urunler; }
            set
            {
                urunler = value;
                OnPropertyChanged();
            }
        }
        public class GununFirsati
        {
            public ImageSource Image { get; set; }
            public String Name { get; set; }
            public String Kategori { get; set; }
            public String Fiyat { get; set; }
            public int Stok { get; set; }
        }
        private ObservableCollection<GununFirsati> gununfirsatlari;
        public ObservableCollection<GununFirsati> GununFirsatlari
        {
            get { return gununfirsatlari; }
            set
            {
                gununfirsatlari = value;
                OnPropertyChanged();
            }
        }

        public class CokSatan
        {
            public ImageSource Image { get; set; }
            public String Name { get; set; }
            public String Kategori { get; set; }
            public String Fiyat { get; set; }
            public int Stok { get; set; }
        }
        private ObservableCollection<CokSatan> coksatanlar;
        public ObservableCollection<CokSatan> CokSatanlar
        {
            get { return coksatanlar; }
            set
            {
                coksatanlar = value;
                OnPropertyChanged();
            }
        }
        public class OneCikanUrun
        {
            public ImageSource Image { get; set; }
            public String Name { get; set; }
            public String Kategori { get; set; }
            public String Fiyat { get; set; }
            public int Stok { get; set; }
        }
        private ObservableCollection<OneCikanUrun> onecikanurunler;
        public ObservableCollection<OneCikanUrun> OneCikanUrunler
        {
            get { return onecikanurunler; }
            set
            {
                onecikanurunler = value;
                OnPropertyChanged();
            }
        }
    }
}