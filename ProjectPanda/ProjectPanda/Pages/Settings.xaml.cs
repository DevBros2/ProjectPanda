using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectPanda.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();
            
        }

        //the event handler for changing the distance proximty 
        private void KilometerChange(object sender, ValueChangedEventArgs args)
        {
            kilometerValue.Text = string.Format("{0}", args.NewValue);
        }

    }
}