using cerkes_haber.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using ImageCircle.Forms.Plugin.Abstractions;

using Xamarin.Forms;

namespace cerkes_haber.pages
{
    public class profilepage : ContentPage
    {
        public profilepage()
        {
            Users item = new Users()
            {
                ID = 101,
                Name = "Yavuz Selim",
                Surname = "Ulucan",
                SecondName = "Thaldi",
                Age = 23,
                City = "Kayseri",
                Village = "Yeni Yapan",
                Part = "Abaza",
                PhoneNumber = "05514376543",
                Address = "Kayseri kocasinan",
                UserImage = new Uri("https://media.licdn.com/mpr/mpr/shrinknp_400_400/AAEAAQAAAAAAAANVAAAAJGEwNjZhZjg1LWYzMzctNGRjZC1iM2ZkLTRkZTZiODI0Nzk3Yg.jpg")
            };



            SetContent(item);
        }



        public void SetContent(Users user)
        {
            var layout = new RelativeLayout();

            var overlay = new Image()
            {
                Aspect = Aspect.AspectFill,
                Source=Device.OnPlatform(
                    Android:ImageSource.FromUri(new Uri("https://www.syntaxismyui.com/wp-content/uploads/2015/05/Overlay.png")),
                    WinPhone:"image/Overlay.png",
                    iOS: ImageSource.FromUri(new Uri("https://www.syntaxismyui.com/wp-content/uploads/2015/05/Overlay.png"))
                    ),
            };

            var picture = new CircleImage()
            {
                //Aspect = Aspect.AspectFill,
                Source = user.UserImage,
                WidthRequest=75,
                HeightRequest=75,
            };


            var name = new Label()
            {
                Text = user.SecondName + " " + user.Name + " " + user.Surname,
                FontSize = 30,
                TextColor = Color.FromHex("#FF6600"),
                FontFamily = Device.OnPlatform("HelveticaNeue-Medium", "Comic Sans MS", "Comic Sans MS")
            };

            var id = new Label() { Text = "Kullanıcı ID: "+ user.ID.ToString() };
            var age = new Label() { Text = "Yaş: " + user.Age.ToString() };
            var city = new Label() { Text = "Şehir: " + user.City };
            var part = new Label() { Text = "Çerkes Boyu: " + user.Part };
            var p_number = new Label() { Text = "Telefon: " + user.PhoneNumber };
            var adress = new Label() { Text = "Adres: " + user.Address };

            var village = new Label()
            {
                Text = "Köy: " + user.Village,
                FontSize = 19,
                FontFamily = Device.OnPlatform("HelveticaNeue-CondensedBlack", "sans-serif-condensed", "Comic Sans MS"),
                TextColor=Color.FromHex("#E27A3F"),
            };


            var flag = new CircleImage()
            {
                Source = Device.OnPlatform(
                    Android: ImageSource.FromUri(new Uri("http://www.bayrakbul.com/imajlar/bayrakresim/abhazya_bayrak.gif")),
                    WinPhone: "image/abhazya_bayragi.png",
                    iOS: ImageSource.FromUri(new Uri("http://www.bayrakbul.com/imajlar/bayrakresim/abhazya_bayrak.gif"))
                    ),
                Opacity=0.3,
                WidthRequest=30,
                HeightRequest=20
            };

            var details = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#3E828F"),
                Spacing = 10,
                Padding = new Thickness(50, 10),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions=LayoutOptions.Center,
                Children = {
                                id,
                                name,
                                city,
                                part,
                                p_number,
                                age,
                                adress,
                                village
                           }
            };

            layout.Children.Add(
                picture,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * .5;
                })
            );

            layout.Children.Add(
               flag,
               Constraint.Constant(0),
               Constraint.Constant(0),
               Constraint.RelativeToParent((parent) =>
               {
                   return parent.Width;
               }),
               Constraint.RelativeToParent((parent) =>
               {
                   return parent.Height * .9;
               })
           );

            layout.Children.Add(
                details,
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * .5;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height;
                })
            );

            layout.Children.Add(
                overlay,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height;
                })
            );

            Content = layout;
        }
    }
}
