using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace cerkes_haber.pages
{
    public class mainpage : ContentPage
    {
        Entry nickBox;
        Entry passwordBox;
        Button loginBtn;
        Button registerBtn;


        public mainpage()
        {
            SetContent();
        }

        private void SetContent()
        {
            Grid baseLayout = new Grid()
            {
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill,
                BackgroundColor = Color.FromHex("004857"),
            };

            StackLayout titleBox = new StackLayout()
            {
                BackgroundColor = Color.FromHex("F45646"),
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Fill,
                HeightRequest = 50
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


            nickBox = new Entry();
            passwordBox = new Entry()
            {
                IsPassword = true
            };
            loginBtn = new Button()
            {
                Text = "Giriş Yap",
                BackgroundColor = Color.FromHex("00BD55"),
                BorderColor = Color.Transparent,
                FontFamily = Device.OnPlatform(
                    iOS: "MarkerFelt-Thin",
                    Android: "Droid Sans Mono",
                    WinPhone: "Comic Sans MS"
                    ),
            };
            registerBtn = new Button()
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
                // Navigation.PushModalAsync(new profilepage());
                Navigation.PushModalAsync(new RegisterUserPage());
            };

            loginBtn.Clicked += (o, e) =>
            {
                Navigation.PushModalAsync(new RootPage());
            };

            StackLayout baseContent = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Fill,
                Children =
                {
                    new Label{
                        Text="Kullanıcı Adı:",
                        HorizontalOptions=LayoutOptions.Center,
                        FontFamily = Device.OnPlatform(
                    iOS: "MarkerFelt-Thin",
                    Android: "Droid Sans Mono",
                    WinPhone: "Comic Sans MS"
                    ),
                    },
                    nickBox,
                    new Label
                    {
                        Text="Şifre:",
                        HorizontalOptions=LayoutOptions.Center,
                        FontFamily = Device.OnPlatform(
                    iOS: "MarkerFelt-Thin",
                    Android: "Droid Sans Mono",
                    WinPhone: "Comic Sans MS"
                    )},
                    passwordBox,
                    loginBtn,
                    registerBtn
                }
            };
            baseLayout.Children.Add(baseContent);

            Content = baseLayout;

        }
    }
}
