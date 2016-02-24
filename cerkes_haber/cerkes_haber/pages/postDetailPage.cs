using cerkes_haber.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace cerkes_haber.pages
{
    public class postDetailPage : ContentPage
    {
        public postDetailPage(EventItem item)
        {
            SetContent(item);
        }

        private void SetContent(EventItem _event)
        {
            AbsoluteLayout peakLayout = new AbsoluteLayout
            {
                HeightRequest = 250,
                BackgroundColor = Color.Black
            };

            var title = new Label
            {
                Text = _event.Title,
                FontSize = 30,
                FontFamily = "AvenirNext-DemiBold",
                TextColor = Color.White
            };

            var place = new Label
            {
                Text = _event.Place,
                TextColor = Color.FromHex("#ddd"),
                FontFamily = "AvenirNextCondensed-Medium"
            };

            var time = new Label
            {
                Text = string.Format("{0:dddd, MMMM d, yyyy}", _event.Time),
                TextColor = Color.FromHex("#08A65F"),
                FontFamily = "AvenirNextCondensed-Medium"
            };

            var city = new Label
            {
                Text = _event.City,
                TextColor = Color.FromHex("#52CEBA"),
                FontFamily = "AvenirNextCondensed-Medium",
                FontSize=22,
                //FontAttributes=FontAttributes.Bold
            };

            var name = new Label
            {
                Text = _event.Name,
                TextColor = Color.FromHex("#52CEBA"),
                FontFamily = "AvenirNextCondensed-Medium",
                FontSize=22,
                //FontAttributes=FontAttributes.Bold
            };

            var image = new Image()
            {
                Source = Device.OnPlatform(
                    iOS: "asd.png",
                    Android: "asd,png",
                    WinPhone: ImageSource.FromUri(new Uri("http://mw2.google.com/mw-panoramio/photos/medium/120511482.jpg"))
                    ),
                Aspect = Aspect.AspectFill
            };

            var overlay = new BoxView()
            {
                Color = Color.Black.MultiplyAlpha(.7f)
            };
            

            var pin = new Image()
            {
                Source = Device.OnPlatform(
                    "pin.png",
                    "pin.png",
                    "image/pin.png"),
                HeightRequest = 25,
                WidthRequest = 25
            };

            var description = new Frame()
            {
                Padding = new Thickness(10, 5),
                HasShadow = false,
                BackgroundColor = Color.Transparent,
                Content = new Label()
                {
                    FontSize = 25,
                    TextColor = Color.FromHex("#ddd"),
                    Text = _event.Description,
                    FontFamily = Device.OnPlatform(
                    iOS: "MarkerFelt-Thin",
                    Android: "Droid Sans Mono",
                    WinPhone: "Comic Sans MS"
                    ),
                }
            };

            AbsoluteLayout.SetLayoutFlags(overlay, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(overlay, new Rectangle(0, 1, 1, 0.3));

            AbsoluteLayout.SetLayoutFlags(image, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(image, new Rectangle(0f, 0f, 1f, 1f));

            AbsoluteLayout.SetLayoutFlags(title, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(title,
                new Rectangle(0.1, 0.85, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );

            AbsoluteLayout.SetLayoutFlags(time, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(time,
                new Rectangle(0.1, 0.95, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );


            AbsoluteLayout.SetLayoutFlags(place, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(place,
                new Rectangle(0.90, 0.9, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );

            AbsoluteLayout.SetLayoutFlags(pin, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(pin,
                new Rectangle(0.70, 0.9, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );


            AbsoluteLayout.SetLayoutFlags(name, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(name,
                new Rectangle(0.70, 0.4, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );

            AbsoluteLayout.SetLayoutFlags(city, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(city,
                new Rectangle(0.40, 0.4, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );


            peakLayout.Children.Add(image);
            peakLayout.Children.Add(overlay);
            peakLayout.Children.Add(title);
            peakLayout.Children.Add(place);
            peakLayout.Children.Add(pin);
            peakLayout.Children.Add(time);
            peakLayout.Children.Add(name);
            peakLayout.Children.Add(city);


            Content = new StackLayout()
            {
                //BackgroundColor = Color.FromHex("#333"),
                BackgroundColor=Color.FromHex("#323C3E"),
                Children = { 
                    peakLayout,
                    description,
                }
            };
        }
    }
}
