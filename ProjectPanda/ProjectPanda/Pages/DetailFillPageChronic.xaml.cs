using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjectPanda.Pages
{
    public partial class DetailFillPageChronic : ContentPage
    {
        public DetailFillPageChronic()
        {
            InitializeComponent();
        }



        async void NextDetailfillPageAllergies(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new DetailFillAllergies());
        }
    }
}
