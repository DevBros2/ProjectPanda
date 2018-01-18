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

        private void Doctor_Button_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new DoctorListView());
        }






    }
}