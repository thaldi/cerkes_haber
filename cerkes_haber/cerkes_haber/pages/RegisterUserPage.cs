using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cerkes_haber.pages
{
    public class RegisterUserPage : ContentPage
    {
        public RegisterUserPage()
        {
            SetContent();
        }

        private void SetContent()
        {
            Grid mainLayout = new Grid()
            {
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill,
                BackgroundColor = Color.FromHex("#32352F")
            };

            Grid baseGrid = new Grid()
            {
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill,
                BackgroundColor = Color.FromHex("6FCDDB")
            };

            Button registerBtn = new Button()
            {
                Text = "Kayıt Ol",
                BackgroundColor = Color.FromHex("00BD55"),
                BorderColor = Color.Transparent,
                FontFamily = Device.OnPlatform(
                    iOS: "MarkerFelt-Thin",
                    Android: "Droid Sans Mono",
                    WinPhone: "Comic Sans MS"
                    ),
            };

            registerBtn.Clicked += (o, e) =>
            {
                //register user event
            };

            StackLayout titleBox = new StackLayout()
            {
                BackgroundColor = Color.FromHex("506D76"),
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Fill,
                HeightRequest = 50
            };

            Label title = new Label()
            {
                Text = "Kullanıcı Kayıt",
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

            Entry name = new Entry() { Placeholder = "İsim" };
            Entry surname = new Entry() { Placeholder = "Soyisim" };
            Entry age = new Entry() { Placeholder = "Yaş" };
            Entry village = new Entry() { Placeholder = "Köy" };
            Picker city = new Picker() { Title = "Şehir" };
            Entry username = new Entry() { Placeholder = "Kullanıcı Adı" };
            Entry userpass = new Entry() { Placeholder = "Parola", IsPassword = true };
            Entry userpassagain = new Entry() { Placeholder = "Parola Tekrar", IsPassword = true };
            Entry partofCircassian = new Entry() { Placeholder = "Çerkes Boyu(abhaz vs.)" };
            Entry phone = new Entry() { Placeholder = "Telefon" };
            Picker contry = new Picker() { Title = "Ülke" };
            Entry mail = new Entry() { Placeholder = "Mail" };


            ScrollView scroll = new ScrollView();

            StackLayout baselayout = new StackLayout()
            {
                Children =
                {
                    titleBox,
                    name,
                    surname,
                    age,
                    village,
                    city,
                    contry,
                    partofCircassian,
                    phone,
                    username,
                    userpass,
                    userpassagain,
                    registerBtn
                }
            };

            StackLayout layout = new StackLayout()
            {
                Children =
                {
                   titleBox,
                   baselayout
                }
            };


            baseGrid.Children.Add(baselayout);

            scroll.Content = baselayout;

            mainLayout.Children.Add(scroll);

            Content = mainLayout;

            SetLists(city, contry);
            city.SelectedIndex = 0;
            contry.SelectedIndex = 0;
        }


        private void SetLists(Picker city, Picker country)
        {
            for (int i = 0; i < helpers.ListHelper.SehirListesi.Count; i++)
            {
                city.Items.Add(helpers.ListHelper.SehirListesi[i]);
            }

            for (int i = 0; i < helpers.ListHelper.UlkeListesi.Count; i++)
            {
                country.Items.Add(helpers.ListHelper.UlkeListesi[i]);
            }
        }

    }
}
