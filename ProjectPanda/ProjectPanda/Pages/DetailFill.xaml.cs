
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProjectPanda.Pages
{
    public partial class DetailFill : ContentPage
    {
        public DetailFill()
        {
            InitializeComponent();
        }


        async void NextDetailfillPage(object sender, EventArgs args)
        {

          await  Navigation.PushAsync(new DetailFillPageChronic());

        }

    }
}
