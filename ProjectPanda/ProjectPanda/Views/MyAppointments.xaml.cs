using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyAppointments : ContentPage
	{
        public Appointment Appointment { get; set; }
        int number = 0;

        public MyAppointments ()
		{
			InitializeComponent ();

            Appointment = new Appointment
            {

            };
            BindingContext = this;
        }

	}
}