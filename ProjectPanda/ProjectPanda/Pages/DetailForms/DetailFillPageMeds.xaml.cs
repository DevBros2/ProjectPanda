using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjectPanda.Pages
{
    public partial class DetailFillPageMeds : ContentPage
    {
        public DetailFillPageMeds()
        {
            InitializeComponent();
        }

        private void MedSwitch(object sender, ToggledEventArgs e)
        {
            if (e.Value == false)
            {
                MedsSearch.IsVisible = false;
            }
            else
            {
                MedsSearch.IsVisible = true;
            }
        }

        async void MainProfilePageNavStack(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProjectPanda.MainPage());
        }


    }
}
