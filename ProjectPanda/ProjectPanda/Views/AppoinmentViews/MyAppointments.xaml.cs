using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyAppointments : ContentPage
	{
		public MyAppointments ()
		{
			InitializeComponent ();
		}

        async void Doctor_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DoctorListView());
            // var newpage = await NavigationPage(new DoctorListView());

        }


        //the event handler for the date picker

        private void Datepick(object sender, DateChangedEventArgs args)
        {
            string formatedDate;
           formatedDate= TheDateForAppointment.Text = args.NewDate.ToString();
        }

        private void Confirm(object sender, EventArgs e)
        {
            //code to confirm the appointemnt 
            XFFlipViewControl1.IsFlipped = !XFFlipViewControl1.IsFlipped;
        }


    }
}