using cerkes_haber.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cerkes_haber.pages
{
    public class RootPage : ContentPage
    {
        //AbsoluteLayout baseLayout;
        //Grid grid;

        public RootPage()
        {
            SetConent();
        }

        private void SetConent()
        {
            var baseLayout = new StackLayout()
            {
                VerticalOptions=LayoutOptions.Fill,
                HorizontalOptions=LayoutOptions.Fill,
                BackgroundColor=Color.FromHex("#D7DDD1")
            };


            StackLayout titleBox = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#F3A382"),
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Fill,
                HeightRequest = 50,
                
            };

            Label title = new Label()
            {
                Text = "Çerkes Haber",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.White,
                FontSize = 30,
                FontFamily = Device.OnPlatform(
                    iOS: "MarkerFelt-Thin",
                    Android: "Droid Sans Mono",
                    WinPhone: "Comic Sans MS"
                    ),
            };
            titleBox.Children.Add(title);
            baseLayout.Children.Add(titleBox);

            Grid layout = new Grid()
            {
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill
            };

            List<EventItem> items = new List<EventItem>()
            {
                new EventItem() {Title="Cenaze",Name="Köy Cenazesi",Flag="image/redFlag.fw.png",City="Sivas",Place="Kazancık",Time=DateTime.Today ,Color=Color.Red,Description="Eski muhtar olan asd vefat etmiştir."},
                new EventItem() {Title="Cenaze",Name="Köy Cenazesi",City="Sivas",Place="Kazancık",Flag="image/redFlag.fw.png",Time=DateTime.Today ,Color=Color.Red},
                new EventItem() {Title="Düğün",Name="Köy Düğünü",City="Tokat",Flag="image/greenFlag.fw.png",Place="Turhal",Time=DateTime.Today , Color=Color.Green,Description="Ata ulucan ile Melek xx dünya evine giriyor. Sizleride aramızda görmekten onur duyarız."},
                new EventItem() {Title="Cenaze",Name="Köy Cenazesi",Flag="image/redFlag.fw.png",City="Sivas",Place="Kazancık",Time=DateTime.Today ,Color=Color.Red},
                new EventItem() {Title="Cenaze",Flag="image/redFlag.fw.png",Name="Köy Cenazesi",City="Amasya",Place="Demirboğa",Time=DateTime.Today,Color=Color.Red },
                new EventItem() {Title="Düğün",Flag="image/greenFlag.fw.png" ,Name="Köy Düğünü",City="Tokat",Place="Niksar",Time=DateTime.Today ,Color=Color.Green},
            };

            var EventList = new ListView();
            var cell = new DataTemplate(typeof(EventTemplate));
            EventList.ItemTemplate = cell;
            EventList.ItemsSource = items.ToList();
            layout.Children.Add(EventList);


            EventList.ItemSelected += async (o, e) =>
            {
                var data = e.SelectedItem as EventItem;
                await Navigation.PushModalAsync(new postDetailPage(data));
            };

            baseLayout.Children.Add(layout);

            Content = baseLayout;

        }

    }
}
