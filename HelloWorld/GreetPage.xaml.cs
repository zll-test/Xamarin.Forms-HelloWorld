using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            Content = new StackLayout
            {
                //Margin = new Thickness(20),

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,

                Children =
                {
                    new Label { Text = "Hello World" },
                    new Slider { }
                }
            };
        }

    }
}
