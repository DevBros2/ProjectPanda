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


        private void showValues_Toggled(object sender, ToggledEventArgs e)
        {
            //this toggle switch displayes or hides the search bar icon
            if (e.Value == false)
            {
                allergySearch.IsVisible = false;
            }
            else
            {
                allergySearch.IsVisible = true;
            }
        }

        async void MainProfilePageNav(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new DetailFillPageMeds());
        }

    }
}
