using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjectPanda.Pages
{
    public partial class DetailFillAllergies : ContentPage
    {
        public DetailFillAllergies()
        {
            InitializeComponent();

        }

        async void MainProfilePageNav(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new DetailFillPageMeds());
        }
    }
}
