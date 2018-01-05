using System;

using Xamarin.Forms;

namespace ProjectPanda.Pages
{
    public class DetailFillPageChronic : ContentPage
    {
        public DetailFillPageChronic()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

