using System;
using System.Collections.Generic;
using ProjectPanda.Pages;
using Xamarin.Forms;

namespace ProjectPanda.Pages
{
    public partial class DetailFillPageChronic : ContentPage
    {
        public DetailFillPageChronic()
        {
            InitializeComponent();
        }

        private void ChronicSearch(object sender, ToggledEventArgs e)
        {
            if (e.Value == false)
            {
                chronicSearch.IsVisible = false;

            }
            else
            {
                chronicSearch.IsVisible = true;
            }
        }

        async void NextDetailfillPageAllergies(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new DetailFillAllergies());
        }


       
    }
}
