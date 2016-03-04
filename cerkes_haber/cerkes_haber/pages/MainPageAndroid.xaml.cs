using cerkes_haber.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace cerkes_haber.pages
{
    public partial class MainPageAndroid : ContentPage
    {
        public MainPageAndroid()
        {
            InitializeComponent();
            SetList();
        }
        private void SetList()
        {
            List<EventItem> items = new List<EventItem>()
            {
                new EventItem() {Title="Cenaze",Name="Köy Cenazesi",Flag="image/redFlag.fw.png",City="Sivas",Place="Kazancık",Time=DateTime.Today ,Color=Color.Red,Description="Eski muhtar olan asd vefat etmiştir."},
                new EventItem() {Title="Cenaze",Name="Köy Cenazesi",City="Sivas",Place="Kazancık",Flag="image/redFlag.fw.png",Time=DateTime.Today ,Color=Color.Red},
                new EventItem() {Title="Düğün",Name="Köy Düğünü",City="Tokat",Flag="image/greenFlag.fw.png",Place="Turhal",Time=DateTime.Today , Color=Color.Green,Description="Ata ulucan ile Melek xx dünya evine giriyor. Sizleride aramızda görmekten onur duyarız."},
                new EventItem() {Title="Cenaze",Name="Köy Cenazesi",Flag="image/redFlag.fw.png",City="Sivas",Place="Kazancık",Time=DateTime.Today ,Color=Color.Red},
                new EventItem() {Title="Cenaze",Flag="image/redFlag.fw.png",Name="Köy Cenazesi",City="Amasya",Place="Demirboğa",Time=DateTime.Today,Color=Color.Red },
                new EventItem() {Title="Düğün",Flag="image/greenFlag.fw.png" ,Name="Köy Düğünü",City="Tokat",Place="Niksar",Time=DateTime.Today ,Color=Color.Green},
            };

            AllPosts.ItemsSource = items;
        }
    }
}
