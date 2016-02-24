using cerkes_haber.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cerkes_haber.model
{
    public class EventTemplate : ViewCell
    {
        public EventTemplate()
        {
            RelativeLayout layout;

            layout = new RelativeLayout()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 170,
                Padding = new Thickness(0),
                BackgroundColor=Color.FromHex("#D7DDD1")
            };

            var cardBackground = new Image()
            {
                Source = Device.OnPlatform(
                    iOS: "",
                    Android: "",
                    WinPhone: ImageSource.FromFile("image/shadow.png")),
                Aspect = Aspect.Fill
            };

            layout.Children.Add(
                cardBackground,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) =>
                {
                    return (parent.Width);
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return (parent.Height);
                })
            );

            Grid grid = new Grid()
            {
                RowDefinitions =
                {
                    new RowDefinition { Height =new GridLength(75,GridUnitType.Auto) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width=new GridLength(15,GridUnitType.Auto) }
                }
            };

            var title = new Label
            {
                FontSize = 30,
                FontFamily = "AvenirNext-DemiBold",
                TextColor = Color.Black
            };

            var place = new Label
            {
                TextColor = Color.FromHex("#ddd"),
                FontFamily = "AvenirNextCondensed-Medium"
            };

            var time = new Label
            {
                TextColor = Color.FromHex("#2364BE"),
                FontFamily = "AvenirNextCondensed-Medium"
            };

            var city = new Label
            {
                //TextColor = Color.FromHex("#52CEBA"),
                TextColor=Color.Black,
                FontFamily = "AvenirNextCondensed-Medium",
                FontSize = 22,
                //FontAttributes=FontAttributes.Bold
            };

            var name = new Label
            {
                //TextColor = Color.FromHex("#52CEBA"),
                TextColor=Color.Black,
                FontFamily = "AvenirNextCondensed-Medium",
                FontSize = 22,
                //FontAttributes=FontAttributes.Bold
            };

            var overlay = new Image()
            {
                //Color = Color.Black.MultiplyAlpha(.7f),
                HeightRequest = 75,
                WidthRequest=30
            };

            title.SetBinding(Label.TextProperty, "Title");
            name.SetBinding(Label.TextProperty, "Name");
            time.SetBinding(Label.TextProperty, "Time");
            city.SetBinding(Label.TextProperty, "City");
            //overlay.SetBinding(BoxView.BackgroundColorProperty, "Color");
            overlay.SetBinding(Image.SourceProperty, "Flag");

            grid.Children.Add(title, 1, 0);
            grid.Children.Add(name, 1, 2);
            grid.Children.Add(time, 1, 1);
            grid.Children.Add(city, 2, 2);
            grid.Children.Add(overlay, 0, 0);

            layout.Children.Add(
                grid,
                Constraint.Constant(10),
                Constraint.Constant(10),
                Constraint.RelativeToParent((parent) =>
                {
                    return (parent.Width - 15);
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return (parent.Height - 0);
                })
            );

            this.View = layout;

        }
    }
}
