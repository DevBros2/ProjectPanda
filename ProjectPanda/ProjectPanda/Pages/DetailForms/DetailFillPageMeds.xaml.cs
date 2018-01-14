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


        async void MainProfilePageNavStack(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProjectPanda.MainPage());
        }


    }
}
